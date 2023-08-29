using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSprite : MonoBehaviour
{
    public Sprite cardFace;
    public Sprite cardBack;
    private SpriteRenderer spriteRenderer;
    private selectableS Selectable;
    private KingsScript kingsScript;
    private UserInput userInput;
   
    void Start()
    {
        //collating variables between scripts
        List<string> deck = KingsScript.GenerateDeck();
        kingsScript = FindObjectOfType<KingsScript>();
        userInput = FindObjectOfType<UserInput>();

        int i = 0;
        foreach (string card in deck)
        {
            if (this.name == card)
            {
                cardFace = kingsScript.cardFaces[i];
                break;
                //give the cards a faceThat is your role in perpetuityWithout you they are facelessWithout you they have no eyesWithout you they cannot seeWithout you they cannot scream
            }
            i++;
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
        Selectable = GetComponent<selectableS>();
    }

   //flip the card
    void Update()
    {
        if (Selectable.faceUp == true && spriteRenderer != null)
        {
            spriteRenderer.sprite = cardFace;
        }
        else
        {
            spriteRenderer.sprite = cardBack;
        }
    }
}
