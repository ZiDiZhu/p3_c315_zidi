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
    public GameObject[] hat;
    private int currentHat;
    public GameObject[] pants;
    private int currentpants;

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

    public void ChangeHat()
    {
        if (currentHat >= hat.Length - 1)
        {
            currentHat = 0;
        }
        else
        {
            currentHat++;
        }

        for (int i = 0; i < hair.Length; i++)
        {
            hat[i].SetActive(false);
        }
        hat[currentHat].SetActive(true);
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


    public void ChangePants()
    {
        if (currentpants >= pants.Length - 1)
        {
            currentpants = 0;
        }
        else
        {
            currentpants++;
        }

        for (int i = 0; i < pants.Length; i++)
        {
            pants[i].SetActive(false);
        }
        pants[currentpants].SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        ChangeHair();
        ChangePants();   
    }

    private void Update()
    {
        playerName.transform.LookAt(Camera.main.transform); //move this to player movement later
    }
}
