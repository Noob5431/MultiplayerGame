using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class furnace : MonoBehaviour
{
    private int goog = 0;
    public float Timer;
    public float timeinfurnace;
    public GameObject gameobj;
    private inventory coc;
    void Awake()
    {
        gameobj = GameObject.Find("player");
    }

    void Start()
    {
        coc = gameobj.GetComponent<inventory>();
    }
    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (goog == 1)
        {
            if(Input.GetKeyUp(KeyCode.E) && coc.HasCoal == true)
            {
                coc.HasCoal = false;
                coc.inventar = false;
                Timer += timeinfurnace;
            }
        }
        //Debug.Log(Timer);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("player"))
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
