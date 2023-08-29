using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;


public class UserInput : MonoBehaviour
{
    public GameObject endScreen;
    private KingsScript kingsScript;
    private selectableS Selectables;
    public GameObject settings;
    private string valueString;
    private int value;
    public GameObject slot1;
    public GameObject rules1;
    public GameObject rules2;
    public GameObject rules3;
    public GameObject rules4;
    public GameObject rules5;
    public GameObject rules6;
    public GameObject rules7;
    public GameObject rules8;
    public GameObject rules9;
    public GameObject rules10;
    public GameObject rules11;
    public GameObject rules12;
    public GameObject rules13;
    string turn;
    int counter = 1;
    public TextMeshProUGUI turntext;
    // During unit testing these variables should be made public. To ensure no future conflicts they do not need to be public in final version.
    List<string> playlist;
    int count;
    public GameObject playerSquare;
    int cardsleft = 52;
    // Start is called before the first frame update
    void Start()
    {
        kingsScript = FindObjectOfType<KingsScript>();
        Selectables = FindObjectOfType<selectableS>();
        playlist = AddPlayers.playerList;
        
       
        count = playlist.Count;
     //  turntext.text = "it's " + playlist[counter] + "'s turn!";
     if (count == 0)
        {
            //playerSquare.SetActive(false);
        }
     else
        {
            turntext.text = "it's " + playlist[0] + "'s turn!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseClick();  
       
    }
    void GetMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        { //where's da mouse pointing? 
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -10));
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit)
            {
                if (hit.collider.CompareTag("Card"))
                {
                    //clicked card
                    Card(hit.collider.gameObject);
                }
                else if (hit.collider.CompareTag("Deck"))
                {

                    Deck();
                }
             
                
            }
        }

    }

  

    void Card(GameObject selected)
    {
        if (selected.GetComponent<selectableS>().faceUp == false && settings.activeInHierarchy == false)
        {
            slot1 = selected;
        selected.GetComponent<selectableS>().faceUp = true;
        value = selected.GetComponent<selectableS>().value;
            //selecting the card gameObj, flipping and transforming it
        selected.transform.position = new Vector3(0, 0, -9);
        selected.transform.localScale = new Vector3(0.8f, 0.8f, 1);
        selected.transform.eulerAngles = new Vector3(0, 0, 0);


        print(value + "this is GETCOMP value: ");

        
       // if value == 1,2,3...
       
        }
       else if (selected.GetComponent<selectableS>().faceUp == true && settings.activeInHierarchy == false)
        {
           
                
                value = selected.GetComponent<selectableS>().value;
          
           
            if (value == 1)
            {
                rules1.SetActive(true);
            }
            if (value == 2)
            {
                rules2.SetActive(true);
            }
            if (value == 3)
            {
                rules3.SetActive(true);
            }
            if (value == 4)
            {
                rules4.SetActive(true);
            }
            if (value == 5)
            {
                rules5.SetActive(true);
            }
            if (value == 6)
            {
                rules6.SetActive(true);
            }
            if (value == 7)
            {
                rules7.SetActive(true);
            }
            if (value == 8)
            {
                rules8.SetActive(true);
            }
            if (value == 9)
            {
                rules9.SetActive(true);
            }
            if (value == 10)
            {
                rules10.SetActive(true);
            }
            if (value == 11)
            {
                rules11.SetActive(true);
            }
            if (value == 12)
            {
                rules12.SetActive(true);
            }
            if (value == 13)
            {
                rules13.SetActive(true);
            }
            // rules (de)activation -- this could be more efficient -- will i improve it? Most likely not

        }
        else if(rules1.active || rules2.active || rules3.active || rules4.active || rules5.active || rules6.active || rules7.active || rules8.active || rules9.active || rules10.active || rules11.active || rules12.active || rules13.active)
        { 
            selected.SetActive(false);
            rules1.SetActive(false);
        }
       





            print("Clicked on card");
       

    }

   public void delCard()
    {
        slot1.SetActive(false);
        playTurn();
        
    }
   
    void Deck()
    {
        print("Clicked on deck");

    }
    void OnPointerDown(PointerEventData eventData)
    {
        //Test to determine if raycast is correct
        Debug.Log("Clicked:  " + eventData.pointerCurrentRaycast.gameObject.name);
        
    }
   public void playTurn()
    {

        cardsleft = cardsleft - 1;

        if (cardsleft >= 1)
        {
            //count  down cards & change player turn
            Debug.Log("CARDS LEFT = " + cardsleft);
            turntext.text = "it's " + playlist[counter] + "'s turn!";
            if (counter < count - 1)
            {
                counter = counter + 1;
                Debug.Log("counter " + counter + "/" + count);
            }
            else if (counter == count - 1 || count != 0)
            {
                counter = 0;
                Debug.Log("Cards left = " + cardsleft);
            }
           
            
        }
        
        if (cardsleft == 0)
        {
            endScreen.SetActive(true);
            Debug.Log("GAME ENDED");
           //end game

        }
    }
    public void DelPlayers()
    {
        AddPlayers.playerList.Clear();
     //clear player list after game is done
    }

}
