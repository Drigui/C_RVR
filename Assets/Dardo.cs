using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dardo : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInParent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.position = GameObject.Find("DartWallLocation").transform.position;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ballon"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("Globo");
        }
        if (other.CompareTag("Wall"))
        {
            GameObject dartWall = new GameObject("DartWallLocation");
            dartWall.transform.position = this.transform.position;
            //dartWallPos = dartWall.transform;
            //Instantiate(dartWall, dartWallPos.position, Quaternion.identity);
            rb.position = dartWall.transform.position;
            rb.angularVelocity = Vector3.zero;
            rb.velocity = Vector3.zero;
            rb.useGravity = false;
            Debug.Log("Wall");
        }
    }
}
