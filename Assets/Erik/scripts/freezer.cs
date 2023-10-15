using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezer : MonoBehaviour
{
    private int goog;
    public GameObject gameobject;
    private inventory inv;
    // Start is called before the first frame update
    void Awake()
    {
        gameobject = GameObject.Find("player");
    }
    void Start()
    {
        inv = gameobject.GetComponent<inventory>();
    }
    //  inv.HasCoal
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && inv.inventar == false)
        {
            if (goog == 1)
            {
                inv.inventar = true;
                inv.HasFood = true;
            }
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
