using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

public class turnUnitTests : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayTurnLastPlayerTest()
    {
        UserInput userInput = new GameObject().AddComponent<UserInput>();

        userInput.playlist = new List<string> { "Player1", "Player2", "Player3" };
        userInput.count = userInput.playlist.Count;
        userInput.cardsleft = 3; // Assuming all players have not played yet
        userInput.counter = userInput.count - 1; // Last player's turn

        // Call the playTurn method
        userInput.playTurn();

        // Assert that the counter is reset to 0
        Assert.AreEqual(0, userInput.counter, "Counter should be reset to 0");

        // Assert that the turn text is updated
        Assert.AreEqual("it's Player1's turn!", userInput.turntext.text, "Turn text should be updated to Player1's turn");
    }


    public void PlayTurnGameEndedTest()
    {
        UserInput userInput = new GameObject().AddComponent<UserInput>();

        userInput.playlist = new List<string> { "Player1", "Player2" };
        userInput.count = userInput.playlist.Count;
        userInput.cardsleft = 1; // Last card

        // Call the playTurn method
        userInput.playTurn();

        // Assert that the end screen is activated
        Assert.IsTrue(userInput.endScreen.activeSelf, "End screen should be activated");

        // Assert that the turn text is not updated
        Assert.AreNotEqual("it's Player2's turn!", userInput.turntext.text, "Turn text should not be updated");
    }
}
