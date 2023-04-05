using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatScript : MonoBehaviour
{
    //public GameObject[] hats;

    //public GameObject topHat;
    //public GameObject wizardHat;
    //public GameObject pizzaHat;
    //public GameObject capHat;

    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        //topHat = GameObject.Find("top hat");

        //hats = GameObject.FindGameObjectsWithTag("hat");
        //foreach (GameObject hat in hats)
        //{
        // hat.SetActive(false);
        //}
        GameObject gmObj = GameObject.Find("GameManagerObj");

        gm = gmObj.GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        //TOP HAT
        if (gm.hatOption == 1)
        {
            Debug.Log("WHY");
            transform.Find("top hat").gameObject.SetActive(true);

        }
        else
        {
            transform.Find("top hat").gameObject.SetActive(false);
        }

        //WIZARD HAT
        if (gm.hatOption == 2)
        {
            Debug.Log("WHY");
            transform.Find("wizard hat").gameObject.SetActive(true);

        }
        else
        {
            transform.Find("wizard hat").gameObject.SetActive(false);
        }

        //BASEBALL HAT
        if (gm.hatOption == 3)
        {
            Debug.Log("WHY");
            transform.Find("cap").gameObject.SetActive(true);

        }
        else
        {
            transform.Find("cap").gameObject.SetActive(false);
        }

        //PIZZA HAT
        if (gm.hatOption == 4)
        {
            Debug.Log("WHY");
            transform.Find("PizzaHat").gameObject.SetActive(true);

        }
        else
        {
            transform.Find("PizzaHat").gameObject.SetActive(false);
        }
    }
}
