using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shirtScript : MonoBehaviour
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
        if (gm.selectedShirt != null)
        {
            // if we're here, something was already selected!
            // 1. Deselect it
            gm.selectedShirt.selected = false;
            gm.selectedShirt.bodyRend.material.color = gm.selectedShirt.defaultColor;
        }
        // 2. Select me!
        selected = true;
        bodyRend.material.color = selectedColor;

        gm.selectedShirt = this;

        if (gameObject.CompareTag("option1"))
        {
            Debug.Log("help");
            gm.shirtOption = 1;
        }

        if (gameObject.CompareTag("option2"))
        {
            Debug.Log("help (but in blue)");
            gm.shirtOption = 2;
        }

        if (gameObject.CompareTag("option3"))
        {
            Debug.Log("help (but in blue)");
            gm.shirtOption = 3;
        }

    }
}
