using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
