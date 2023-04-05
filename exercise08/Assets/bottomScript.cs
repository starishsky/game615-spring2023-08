using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomScript : MonoBehaviour
{
    //public GameObject[] bottoms;

    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {

        GameObject gmObj = GameObject.Find("GameManagerObj");

        gm = gmObj.GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        //PANTS
        if (gm.bottomOption == 1)
        {
            
            transform.Find("pants").gameObject.SetActive(true);

        }
        else
        {
            transform.Find("pants").gameObject.SetActive(false);
        }

        //SHORTS
        if (gm.bottomOption == 2)
        {
            
            transform.Find("shorts").gameObject.SetActive(true);

        }
        else
        {
            transform.Find("shorts").gameObject.SetActive(false);
        }

        //SKIRT
        if (gm.bottomOption == 3)
        {
            
            transform.Find("skirt").gameObject.SetActive(true);

        }
        else
        {
            transform.Find("skirt").gameObject.SetActive(false);
        }

    }
}
