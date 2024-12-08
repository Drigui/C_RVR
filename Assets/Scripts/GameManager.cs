using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject objSpawner;
    public GameObject objSpawner1;
    public GameObject obj;
    public GameObject obj1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(obj, objSpawner.transform.position, Quaternion.identity);
            Instantiate(obj1, objSpawner1.transform.position, Quaternion.identity);
        }
        
    }
}
