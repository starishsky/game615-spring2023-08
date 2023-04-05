using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petScript : MonoBehaviour
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
        //FISH
        if (gm.petOption == 1)
        {

            transform.Find("goldfish").gameObject.SetActive(true);

        }
        else
        {
            transform.Find("goldfish").gameObject.SetActive(false);
        }

        //CAT
        if (gm.petOption == 2)
        {

            transform.Find("cat").gameObject.SetActive(true);

        }
        else
        {
            transform.Find("cat").gameObject.SetActive(false);
        }

        //PIZZA STEVE
        if (gm.petOption == 3)
        {

            transform.Find("pizzSteve").gameObject.SetActive(true);

        }
        else
        {
            transform.Find("pizzSteve").gameObject.SetActive(false);
        }

    }
}
