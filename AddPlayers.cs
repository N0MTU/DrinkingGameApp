using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AddPlayers : MonoBehaviour
{
    public GameObject inputField;
    public GameObject start;
    string[] players = { "", "", "", "", "", "", "", "" };
    public TextMeshProUGUI player1Name;
    public TextMeshProUGUI player2Name;
    public TextMeshProUGUI player3Name;
    public TextMeshProUGUI player4Name;
    public TextMeshProUGUI player5Name;
    public TextMeshProUGUI player6Name;
    public TextMeshProUGUI player7Name;
    public TextMeshProUGUI player8Name;
    public static List<string> playerList = new List<string>();
    public KingsScript playFoot;

    private TouchScreenKeyboard mobileKeys;

    // CAN ADD UP TO 52 PLAYERS, BUT POSSIBLY 16 TO START
    // hide text "player x:" until player is added
    // figure out how scroll works on phone


    //DelButtons
    public GameObject ddelP1;
    public GameObject ddelP2;
    public GameObject ddelP3;
    public GameObject ddelP4;
    public GameObject ddelP5;
    public GameObject ddelP6;
    public GameObject ddelP7;
    public GameObject ddelP8;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //mayhaps when mobile keyboard is closed, player is added?
        if (mobileKeys.done)
        {
            addPlayer();
        }
    }
    public void addPlayer() 
    
    {
        string pName = inputField.GetComponent<TMP_InputField>().text;
        //this whole thing can be put in a loop when refining 
        if (players[0].Length == 0)
        { 
            players[0] = pName;
            player1Name.text = players[0];
            Debug.Log("PLAYER 1 NAME IS: " + players[0]);
            inputField.GetComponent<TMP_InputField>().text = "";
            playerList.Add(players[0]);
            ddelP1.SetActive(true);
        }
        else if (players[1].Length == 0)
        {
            players[1] = pName;
            player2Name.text = players[1];
            Debug.Log("PLAYER 2 NAME IS: " + players[1]);
            inputField.GetComponent<TMP_InputField>().text = "";
            playerList.Add(players[1]);
            ddelP2.SetActive(true);
        }
        else if (players[2].Length == 0)
        {
            players[2] = pName;
            player3Name.text = players[2];
            Debug.Log("PLAYER 3 NAME IS: " + players[2]);
            inputField.GetComponent<TMP_InputField>().text = "";
            playerList.Add(players[2]);
            ddelP3.SetActive(true);
        }
        else if (players[3].Length == 0)
        {
            players[3] = pName;
            player4Name.text = players[3];
            Debug.Log("PLAYER 4 NAME IS: " + players[3]);
            inputField.GetComponent<TMP_InputField>().text = "";
            playerList.Add(players[3]);
            ddelP4.SetActive(true);
        }
        else if (players[4].Length == 0)
        {
            players[4] = pName;
            player5Name.text = players[4];
            Debug.Log("PLAYER 5 NAME IS: " + players[4]);
            inputField.GetComponent<TMP_InputField>().text = "";
            playerList.Add(players[4]);
            ddelP5.SetActive(true);
        }
        else if (players[5].Length == 0)
        {
            players[5] = pName;
            player6Name.text = players[5];
            Debug.Log("PLAYER 6 NAME IS: " + players[5]);
            inputField.GetComponent<TMP_InputField>().text = "";
            playerList.Add(players[5]);
            ddelP6.SetActive(true);
        }
        else if (players[6].Length == 0)
        {
            players[6] = pName;
            player7Name.text = players[6];
            Debug.Log("PLAYER 7 NAME IS: " + players[6]);
            inputField.GetComponent<TMP_InputField>().text = "";
            playerList.Add(players[6]);
            ddelP7.SetActive(true);
        }
        else if (players[7].Length == 0)
        {
            players[7] = pName;
            player8Name.text = players[7];
            Debug.Log("PLAYER 8 NAME IS: " + players[7]);
            inputField.GetComponent<TMP_InputField>().text = "";
            playerList.Add(players[7]);
            ddelP8.SetActive(true);
        }
        //i mean this WHOLE thing, plus extra players
        else
        {
            Debug.Log("Failure in Player Add");
        }
        


    }
    public void playerlist()
    {
        start.SetActive(true);

        foreach (var item in playerList)
        {
            Debug.Log(item.ToString());

        }   
        //occurs when player clicks play: need pop up (are all players added?) yes/no 
        //no closes popup, yes loads scene
    }
    public void delP1()
    {
        players[0] = "";
        player1Name.text = "";
        playerList.RemoveAt(0);
        ddelP1.SetActive(false);
    }
    public void delP2()
    {
        players[1] = "";
        player2Name.text = "";
        playerList.RemoveAt(1);
        ddelP2.SetActive(false);

    }
    public void delP3()
    {
        players[2] = "";
        player3Name.text = "";
        playerList.RemoveAt(2);
        ddelP3.SetActive(false);
    }
    public void delP4()
    {
        players[3] = "";
        player4Name.text = "";
        playerList.RemoveAt(3);
        ddelP4.SetActive(false);
    }
    public void delP5()
    {
        players[4] = "";
        player5Name.text = "";
        playerList.RemoveAt(4);
        ddelP5.SetActive(false);
    }
    public void delP6()
    {
        players[5] = "";
        player6Name.text = "";
        playerList.RemoveAt(5);
        ddelP6.SetActive(false);
    }
    public void delP7()
    {
        players[6] = "";
        player7Name.text = "";
        playerList.RemoveAt(6);
        ddelP7.SetActive(false);
    }
    public void delP8()
    {
        players[7] = "";
        player8Name.text = "";
        playerList.RemoveAt(7);
        ddelP8.SetActive(false);
    }
    public void OnInputEvent()
    {
        mobileKeys = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false);
    }
}
