using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KingsScript : MonoBehaviour
{
    public Sprite[] cardFaces;
    public GameObject cardPrefab;
 
    
    public static string[] suits = new string[] { "C", "D", "H", "S" };
    public static string[] values = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
   
    int p;
    public List<string> deck;
    
   
    void Start()
    {
        PlayCards();
        

        //  Debug.Log("player list =" + playerlist[0]);

    }

    void Update()
    {

    }

    public void PlayCards()
    {
        //main function to create, shuffle, and spread a deck of cards.
        deck = GenerateDeck();
        Shuffle(deck);

        //test
        foreach (string card in deck)
        {
            print(card);
        }
        StartCoroutine(KingsDeal());
    }

    public static List<string> GenerateDeck()
    { //generate a deck of cards, each card containing a value and a suit
        List<string> newDeck = new List<string>();
        foreach (string s in suits)
        {
            foreach (string v in values)
            {
                newDeck.Add(s + v);
            }
        }
        return newDeck;
    }

    public void Shuffle<T>(List<T> list)
    { //shuffle the deck of cards using random function.
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }

    }

    IEnumerator KingsDeal()
    { //deal a card every .02 seconds, adjusting the position each card to form the circle commonly found in king's cup games.
        float yOffset = -2.5f;
        float i = 0f;
        float AngleOffset = 90;
        float xOffset = 0.6f;
        float zOffset = -0.1f;

        foreach (string card in deck)
        {
            yield return new WaitForSeconds(0.02f);
            GameObject newCard = Instantiate(cardPrefab, new Vector3(transform.position.x + xOffset + 0.3f, transform.position.y + yOffset, transform.position.z + zOffset), Quaternion.Euler(new Vector3(0, 0, AngleOffset)));
            newCard.name = card;
            newCard.GetComponent<selectableS>().faceUp = false;
            // rotating in a circle
            i = i + 0.62f;
            zOffset = zOffset - 0.1f;
            yOffset = yOffset + Mathf.Sin(i);
            xOffset = xOffset + Mathf.Cos(i);
            AngleOffset = AngleOffset + 33;

        }
    }

}
