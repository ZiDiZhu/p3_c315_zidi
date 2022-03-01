using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// rewrite this code

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
    public Color[] skinColor; public int currentSkinColor; public Slider skinSlider;
    public Color[] hairColor; public int currentHairColor; public Slider hairSlider;
    public Color[] coatColor; public int currentCoatColor; public Slider coatSlider;
    public Color[] pantsColor; public int currentPantsColor; public Slider pantsSlider;

    public Material teamMat;
    public Material skinMat;
    public Material hairMat;
    public Material coatMat;
    public Material pantsMat;

    

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
        currentHairColor = index;
        hairSlider.value = 0;
    }

    public void TuneHairColor(int value)
    {
        //change this to change hue and saturation
        //hairMat.color = new Color(currentHairColor.r + hairSlider.value * 0.02f, currentHairColor.g+hairSlider.value*-0.02f, currentHairColor.b);
        float H, S, V;
        Color.RGBToHSV(hairColor[currentHairColor], out H, out S, out V);
        hairMat.color = Color.HSVToRGB(H + 0.01f*hairSlider.value,S + 0.02f * hairSlider.value, V + 0.05f * hairSlider.value);
    }

    public void ChangeCoatColor(int index)
    {
        coatMat.color = coatColor[index];
        currentCoatColor = index;
        coatSlider.value = 0;
    }

    public void TuneCoatColor(float value)
    {
        //change this to change hue and saturation
        //hairMat.color = new Color(currentHairColor.r + hairSlider.value * 0.02f, currentHairColor.g+hairSlider.value*-0.02f, currentHairColor.b);
        float H, S, V;
        value = coatSlider.value;
        Color.RGBToHSV(coatColor[currentCoatColor], out H, out S, out V);
        coatMat.color = Color.HSVToRGB(H + 0.01f * value, S + 0.02f * value, V + 0.05f * value);
    }

    public void ChangeSkinColor(int index)
    {
        skinMat.color = skinColor[index];
        currentSkinColor = index;
        skinSlider.value = 0;
    }

    public void TuneSkinColor(float value)
    {
        //change this to change hue and saturation
        //hairMat.color = new Color(currentHairColor.r + hairSlider.value * 0.02f, currentHairColor.g+hairSlider.value*-0.02f, currentHairColor.b);
        float H, S, V;
        value = skinSlider.value;
        Color.RGBToHSV(skinColor[currentSkinColor], out H, out S, out V);
        skinMat.color = Color.HSVToRGB(H + 0.01f * value, S + 0.02f * value, V + 0.05f * value);
    }

    public void ChangePantsColor(int index)
    {
        pantsMat.color = pantsColor[index];
        currentPantsColor = index;
        pantsSlider.value = 0;
    }

    public void TunePantsColor(float value)
    {
        //change this to change hue and saturation
        //hairMat.color = new Color(currentHairColor.r + hairSlider.value * 0.02f, currentHairColor.g+hairSlider.value*-0.02f, currentHairColor.b);
        float H, S, V;
        value = pantsSlider.value;
        Color.RGBToHSV(pantsColor[currentPantsColor], out H, out S, out V);
        pantsMat.color = Color.HSVToRGB(H + 0.01f * value, S + 0.02f * value, V + 0.05f * value);
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
        ChangeHat();
        ChangePants();   
    }

    private void Update()
    {
        playerName.transform.LookAt(Camera.main.transform); //move this to player movement later
    }
}
