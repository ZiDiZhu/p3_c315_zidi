using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// rewrite this 

public class CustomizeCharacter : MonoBehaviour
{
    public InputField myName; //stores the player's name
    public GameObject playerName; //refers to the text mesh display above player
    public GameObject[] hair;
    private int currentHair;
    public GameObject[] coat;
    private int currentCoat;

    public Color[] teamColor;
    public Color[] skinColor;
    public Color[] hairColor;
    public Color[] coatColor;
    public Color[] pantsColor;
    public Color[] bootsColor;

    public Material teamMat;
    public Material skinMat;
    public Material hairMat;
    public Material coatMat;
    public Material pantsMat;
    public Material bootsMat;

    

    public void ChangeHair()
    {
        if(currentHair >= hair.Length - 1)
        {
            currentHair = 0;
        }
        else
        {
            currentHair++;
        }
        
        for (int i=0; i < hair.Length; i++)
        {
            hair[i].SetActive(false);
        }
        hair[currentHair].SetActive(true);
    }

    public void ChangeName(string name)
    {
        name = myName.text;
        playerName.transform.GetChild(0).GetComponent<TextMesh>().text = name;
    }

    public void ChangeTeamColor(int index)
    {
        teamMat.color = teamColor[index];
        playerName.transform.GetChild(0).GetComponent<TextMesh>().color = teamColor[index];
    }

    public void ChangeHairColor(int index)
    {
        hairMat.color = hairColor[index];
    }

    public void ChangeCoatColor(int index)
    {
        coatMat.color = coatColor[index];
    }

    public void ChangeSkinColor(int index)
    {
        skinMat.color = skinColor[index];
    }

    public void ChangePantsColor(int index)
    {
        pantsMat.color = pantsColor[index];
    }
    public void ChangeBootsColor(int index)
    {
        bootsMat.color = bootsColor[index];
    }


    public void ChangeCoat()
    {
        if (currentCoat >= coat.Length - 1)
        {
            currentCoat = 0;
        }
        else
        {
            currentCoat++;
        }

        for (int i = 0; i < coat.Length; i++)
        {
            coat[i].SetActive(false);
        }
        coat[currentCoat].SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        ChangeHair();
        ChangeCoat();   
    }

    private void Update()
    {
        playerName.transform.LookAt(Camera.main.transform); //move this to player movement later
    }
}
