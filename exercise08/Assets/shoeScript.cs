using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoeScript : MonoBehaviour
{

    public Renderer bodyRend;
    //public Renderer shirtRend;

    public Color hoverColor;
    public Color selectedColor;
    public Color defaultColor;

    public bool selected = false;



    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        bodyRend = GetComponent<Renderer>();
        defaultColor = bodyRend.material.color;

        //shirtRend = defaultShirt.GetComponent<Renderer>();

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
        if (gm.selectedShoe != null)
        {
            // if we're here, something was already selected!
            // 1. Deselect it
            gm.selectedShoe.selected = false;
            gm.selectedShoe.bodyRend.material.color = gm.selectedShoe.defaultColor;
        }
        // 2. Select me!
        selected = true;
        bodyRend.material.color = selectedColor;

        gm.selectedShoe = this;

        if (gameObject.CompareTag("option1"))
        {
            Debug.Log("help");
            gm.shoeOption = 1;
        }

        if (gameObject.CompareTag("option2"))
        {
            Debug.Log("help (but in blue)");
            gm.shoeOption = 2;
        }

        if (gameObject.CompareTag("option3"))
        {
            Debug.Log("help (but in green)");
            gm.shoeOption = 3;
        }

    }
}
