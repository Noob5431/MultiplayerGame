using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveitem : MonoBehaviour
{
    public GameObject coc;
    // Start is called before the first frame update
    void Awake()
    {
        coc = GameObject.FindGameObjectWithTag("player");
    }
    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }
    public void MoveGameObject()
    {
        transform.position = new Vector3(coc.transform.position.x,(float)(coc.transform.position.y - 0.25));
    }
}
