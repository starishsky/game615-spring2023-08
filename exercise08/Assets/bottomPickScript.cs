using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomPickScript : MonoBehaviour
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
        if (gm.selectedBottom != null)
        {

            gm.selectedBottom.selected = false;
            gm.selectedBottom.bodyRend.material.color = gm.selectedBottom.defaultColor;
        }

        selected = true;
        bodyRend.material.color = selectedColor;

        gm.selectedBottom = this;

        if (gameObject.CompareTag("option1"))
        {

            gm.bottomOption = 1;
        }

        if (gameObject.CompareTag("option2"))
        {

            gm.bottomOption = 2;
        }

        if (gameObject.CompareTag("option3"))
        {

            gm.bottomOption = 3;
        }

    }
}
