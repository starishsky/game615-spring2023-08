using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shirtColorScript : MonoBehaviour
{
    public GameManager script;
    public Renderer rend;

    public Material pink;
    public Material green;
    public Material purple;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(script.shirtOption);
     
        if (script.shirtOption == 1)
        {
            rend.material = pink;

        }
        if (script.shirtOption == 2)
        {
            rend.material = green;

        }
        if (script.shirtOption == 3)
        {
            rend.material = purple;

        }
    }
}
