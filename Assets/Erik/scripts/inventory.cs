using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public bool inventar;
    public bool HasCoal;
    public bool HasFood;


    GameObject gam;
    bool verifcoal;
    bool veriffood;

    public GameObject CoalPrefab;
    public GameObject FoodPrefab;
    public Transform carryPosition;

    public int health;
    public float Healthtimer;

    public float SetHealthtimer;
    public int MaxHealth;

   // private GameObject PileOfCoal;
   // private GameObject Furnal;

    void Start()
    {
        verifcoal = true;
        veriffood = true;
        health = MaxHealth;
        Healthtimer = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        Healthtimer += Time.deltaTime;
        if(Healthtimer > SetHealthtimer)
        {
            health--;
            Healthtimer = 0f;
        }
        if(health >4)
        {
            health--;
        }
        Debug.Log(HasFood);
        /* if (Input.GetKeyUp(KeyCode.E) && inventar == false)
         {
             if(PileOfCoal != null)
             {
                 inventar = true;
                 HasCoal = true;

             }
         }*/
        /*if(Input.GetKeyUp(KeyCode.E) && inventar == true)
        {
            if(Furnal != null)
            {
               // cool = false;
                inventar = false;
            }
        }*/
        if (Input.GetKeyUp(KeyCode.R))
        {
            HasCoal = false;
            inventar = false;
            HasFood = false;
        }
        VerifyCoal();
        VerifyFood();
        
    }
    
    private void VerifyCoal()
    {
        if(HasCoal == true && verifcoal == true)
        {
            gam = Instantiate(CoalPrefab, carryPosition.position, Quaternion.identity);
            verifcoal = false;
        }
        if (HasCoal == false && verifcoal == false)
        {
            Destroy(gam);
            verifcoal = true;
        }
    }
    private void VerifyFood()
    {
        if (HasFood == true && veriffood == true)
        {
            gam = Instantiate(FoodPrefab, carryPosition.position, Quaternion.identity);
            veriffood = false;
        }
        if (HasFood == false && veriffood == false)
        {
            Destroy(gam);
            veriffood = true;
        }

    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("coal"))
        {
            PileOfCoal = collision.gameObject;
        }
        if(collision.CompareTag("furnace"))
        {
            Furnal = collision.gameObject;
        }

    }*/
    /*private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("coal"))
        {
            if (collision.gameObject == PileOfCoal)
            {
                PileOfCoal = null;
            }
        }
        if (collision.CompareTag("furnace"))
        {
            if(collision.gameObject == Furnal)
            {
                Furnal = null;
            }
        }
    }*/
}
