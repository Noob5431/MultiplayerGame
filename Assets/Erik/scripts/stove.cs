using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stove : MonoBehaviour
{
    private int goog = 0;
    public GameObject gameobj;
    private inventory coc;

    private int FoodStove;
    private bool NeedFood;

    GameObject spa;
    public GameObject stove1prefab;
    public GameObject stove2prefab;
    public GameObject stove3prefab;
    public GameObject stove4prefab;

    public Transform spawnstove;

    private float timer;
    private bool check;
    GameObject asd;
    public GameObject workprefab;
    private bool ceva;
    public float stovetimer;

    void Awake()
    {
        gameobj = GameObject.Find("player");
    }

    void Start()
    {
        coc = gameobj.GetComponent<inventory>();
        FoodStove = 0;
        check = false;
        timer = 0f;
        ceva = false;
    }
    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
        if (goog == 1)
        {
            if (Input.GetKeyUp(KeyCode.E) && coc.HasFood == true)
            {
                coc.HasFood = false;
                coc.inventar = false;
                check = true;
                ceva = true;
                /*FoodStove++;
                NeedFood = false;*/
            }
        }
        if(check == true)
        {
            timer += Time.deltaTime;
        }
        if(timer >= stovetimer)
        {
            FoodStove++;
            NeedFood = false;
            check = false;
            timer = 0f;
        }
        if(FoodStove > 4)
        {
            FoodStove--;
        }
        if(goog == 1)
        {
            if(Input.GetKeyDown(KeyCode.E) && FoodStove >= 1 && coc.HasFood == false && coc.health != 4)
            {
                FoodStove--;
                NeedFood = false;
                coc.health++;
            }
        }
        verify();
        if (check == true && ceva == true)
        {
            asd = Instantiate(workprefab, spawnstove.position, Quaternion.identity);
            ceva = false;
        }
        if (check == false)
        {
            Destroy(asd);
        }

    }

    void verify()
    {
        if(FoodStove == 1 && NeedFood == false)
        {
            Destroy(spa);
            spa = Instantiate(stove1prefab, spawnstove.position, Quaternion.identity);
            NeedFood = true;
        }
        if (FoodStove == 2 && NeedFood == false)
        {
            Destroy(spa);
            spa = Instantiate(stove2prefab, spawnstove.position, Quaternion.identity);
            NeedFood = true;
        }
        if (FoodStove == 3 && NeedFood == false)
        {
            Destroy(spa);
            spa = Instantiate(stove3prefab, spawnstove.position, Quaternion.identity);
            NeedFood = true;
        }
        if (FoodStove == 4 && NeedFood == false)
        {
            Destroy(spa);
            spa = Instantiate(stove4prefab, spawnstove.position, Quaternion.identity);
            NeedFood = true;
        }
        if(FoodStove == 0)
        {
            Destroy(spa);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            goog = 1;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            goog = 0;
        }
    }
}
