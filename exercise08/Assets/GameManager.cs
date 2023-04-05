using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public shirtScript selectedShirt;
    public float shirtOption = 0;

    public shoeScript selectedShoe;
    public float shoeOption = 0;

    public hatPickScript selectedHat;
    public float hatOption = 0;

    public bottomPickScript selectedBottom;
    public float bottomOption = 0;

    public petPickScript selectedPet;
    public float petOption = 0;

    public Slider tone;
    public Slider undertone;
    public Slider skinSat;
    public Color skinColor;
    public Material skin;


    // Start is called before the first frame update
    void Start()
    {
         tone.maxValue = 1;
        undertone.maxValue = .15f;
        skinSat.maxValue = .3f;

       // m_SliderValue.maxValue = 1;

        tone.minValue = .1f;
        undertone.minValue = 0;
        skinSat.minValue = .2f;
        //m_SliderValue.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Color st = new Color(tone.value, undertone.value, 1);
        if(tone.value>= .7){
            skinSat.minValue =.1f;
        }
        else{
            skinSat.minValue =.2f;
        }
        skin.color=Color.HSVToRGB(undertone.value, skinSat.value,tone.value);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray) == false)
            {
                if (selectedShirt != null)
                {
                    selectedShirt.selected = false;
                    selectedShirt.bodyRend.material.color = selectedShirt.defaultColor;

                    selectedShirt = null;

                }

                if (selectedShoe != null)
                {
                    selectedShoe.selected = false;
                    selectedShoe.bodyRend.material.color = selectedShoe.defaultColor;

                    selectedShoe = null;

                }

                if (selectedHat != null)
                {
                    selectedHat.selected = false;
                    selectedHat.bodyRend.material.color = selectedHat.defaultColor;

                    selectedHat = null;

                }

                if (selectedBottom != null)
                {
                    selectedBottom.selected = false;
                    selectedBottom.bodyRend.material.color = selectedBottom.defaultColor;

                    selectedBottom = null;

                }

                if (selectedPet != null)
                {
                    selectedPet.selected = false;
                    selectedPet.bodyRend.material.color = selectedPet.defaultColor;

                    selectedPet = null;

                }
            }
        }
    }
}
