using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petPickScript : MonoBehaviour
{

    public Renderer bodyRend;

    public Color hoverColor;
    public Color selectedColor;
    public Color defaultColor;

    public bool selected = false;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        bodyRend = GetComponent<Renderer>();
        defaultColor = bodyRend.material.color;

        GameObject gmObj = GameObject.Find("GameManagerObj");

        gm = gmObj.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseEnter()
    {
        if (selected == false)
        {
            bodyRend.material.color = hoverColor;
        }

    }

    private void OnMouseExit()
    {
        if (selected == false)
        {
            bodyRend.material.color = defaultColor;
        }
    }

    private void OnMouseDown()
    {
        if (gm.selectedPet != null)
        {

            gm.selectedPet.selected = false;
            gm.selectedPet.bodyRend.material.color = gm.selectedPet.defaultColor;
        }

        selected = true;
        bodyRend.material.color = selectedColor;

        gm.selectedPet = this;

        if (gameObject.CompareTag("option1"))
        {

            gm.petOption = 1;
        }

        if (gameObject.CompareTag("option2"))
        {

            gm.petOption = 2;
        }

        if (gameObject.CompareTag("option3"))
        {

            gm.petOption = 3;
        }

    }
}
