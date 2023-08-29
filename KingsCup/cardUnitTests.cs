using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

public class cardUnitTests
{

    //Unit Tests for Kings Cup Script

    public IEnumerator DeckGenerationTest()
    {
        List<string> generatedDeck = KingsScript.GenerateDeck();

        // Assert that the generated deck has the expected number of cards (52) 
        Assert.AreEqual(52, generatedDeck.Count, "Generated deck should have 52 cards");

        // Check that each card combo is present in the generated deck
        foreach (string suit in KingsScript.suits)
        {
            foreach (string value in KingsScript.values)
            {
                string card = suit + value;
                Assert.Contains(card, generatedDeck, "Generated deck should contain card: " + card);
            }
        }

        yield return null;
    }

    // test for deck shuffle
    public IEnumerator ShuffleTest()
    {
        KingsScript ks = new GameObject().AddComponent<KingsScript>();
        // create a list to shuffle
        List<int> originalList = new List<int> { 1, 2, 3, 4, 5 };
        List<int> shuffledList = new List<int>(originalList);
        //shuffle list
        ks.Shuffle(shuffledList);

        // Assert that the shuffled list is not the same as the original list
        CollectionAssert.AreNotEqual(originalList, shuffledList, "Shuffled list should not be the same as the original list");

        yield return null;
    }

   //test for dealing cards 
    public IEnumerator DealCardsTest()
    {
        KingsScript ks = new GameObject().AddComponent<KingsScript>();
        // Mock card prefab
        ks.cardPrefab = new GameObject();

        // mini test deck 
        List<string> mockDeck = new List<string> { "CA", "D2", "HQ", "S5" }; 

        ks.deck = mockDeck;

        ks.PlayCards(); 

        yield return new WaitForSeconds(1.0f);

        // Find all the dealt cards in the scene
        GameObject[] dealtCards = GameObject.FindGameObjectsWithTag("Card");

        // Assert that the number of dealt cards matches the mock deck size
        Assert.AreEqual(mockDeck.Count, dealtCards.Length, "Number of dealt cards should match the mock deck");

        for (int i = 0; i < mockDeck.Count; i++)
        {
            Assert.AreEqual(mockDeck[i], dealtCards[i].name, "Dealt card name should match the mock deck");
        }
    }
}
