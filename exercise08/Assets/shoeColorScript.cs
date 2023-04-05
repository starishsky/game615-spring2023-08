using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoeColorScript : MonoBehaviour
{
    public GameManager script;
    public Renderer rend;

    public Material blue;
    public Material pink;
    public Material yellow;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(script.shoeOption);

        if (script.shoeOption == 1)
        {
            rend.material = blue;

        }
        if (script.shoeOption == 2)
        {
            rend.material = pink;

        }
        if (script.shoeOption == 3)
        {
            rend.material = yellow;

        }
    }
}
