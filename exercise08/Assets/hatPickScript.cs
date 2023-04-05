using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatPickScript : MonoBehaviour
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
        if (gm.selectedHat != null)
        {

            gm.selectedHat.selected = false;
            gm.selectedHat.bodyRend.material.color = gm.selectedHat.defaultColor;
        }

        selected = true;
        bodyRend.material.color = selectedColor;

        gm.selectedHat = this;

        if (gameObject.CompareTag("option1"))
        {
            Debug.Log("help");
            gm.hatOption = 1;
        }

        if (gameObject.CompareTag("option2"))
        {
            Debug.Log("help (but in blue)");
            gm.hatOption = 2;
        }

        if (gameObject.CompareTag("option3"))
        {
            Debug.Log("help (but in green)");
            gm.hatOption = 3;
        }

        if (gameObject.CompareTag("option4"))
        {
            Debug.Log("help (but in green)");
            gm.hatOption = 4;
        }
    }
}
