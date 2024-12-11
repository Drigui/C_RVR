using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [Header("Aro")]
    public GameObject aroSpawner;
    public GameObject aro;
    [SerializeField] private List<GameObject> aroListaObjs = new List<GameObject>();
    private BoxCollider aroBoundSpawn;

    public GameObject aroSpawner1;
    public GameObject aro1;
    [SerializeField] private List<GameObject> aroListaObjs1 = new List<GameObject>();
    private BoxCollider aroBoundSpawn1;

    [Header("Dardo")]
    public GameObject dardoSpawner;
    public GameObject dardo;
    [SerializeField] private List<GameObject> dardoListaObjs = new List<GameObject>();
    private BoxCollider dardoBoundSpawn;
    
    public GameObject dardoSpawner1;
    public GameObject dardo1;
    [SerializeField] private List<GameObject> dardoListaObjs1 = new List<GameObject>();
    private BoxCollider dardoBoundSpawn1;

    [Header("Bolas")]
    public GameObject bolasSpawner;
    public GameObject bolas;
    [SerializeField] private List<GameObject> bolasListaObjs = new List<GameObject>();
    private BoxCollider bolasBoundSpawn;

    public GameObject bolasSpawner1;
    public GameObject bolas1;
    [SerializeField] private List<GameObject> bolasListaObjs1 = new List<GameObject>();
    private BoxCollider bolasBoundSpawn1;

    // Start is called before the first frame update
    void Start()
    {

        //dardo0
        dardoBoundSpawn = dardoSpawner.GetComponent<BoxCollider>();
        //dardoListaObjs.Add(Instantiate(dardo, dardoSpawner.transform.position, Quaternion.Euler(90, 0, 0)));
        //dardo1
        dardoBoundSpawn1 = dardoSpawner1.GetComponent<BoxCollider>();
        //dardoListaObjs1.Add(Instantiate(dardo1, dardoSpawner1.transform.position, Quaternion.Euler(90, 0, 0)));
        //aro0
        aroBoundSpawn = aroSpawner.GetComponent<BoxCollider>();
        //aroListaObjs.Add(Instantiate(aro, aroSpawner.transform.position, Quaternion.identity));
        //aro1
        aroBoundSpawn1 = aroSpawner1.GetComponent<BoxCollider>();
        //aroListaObjs1.Add(Instantiate(aro1, aroSpawner1.transform.position, Quaternion.identity));
        //bola0
        bolasBoundSpawn = bolasSpawner.GetComponent<BoxCollider>();
        //bolasListaObjs.Add(Instantiate(bolas, bolasSpawner.transform.position, Quaternion.identity));
        //bolas1
        bolasBoundSpawn1 = bolasSpawner1.GetComponent<BoxCollider>();
        //bolasListaObjs1.Add(Instantiate(bolas1, bolasSpawner1.transform.position, Quaternion.identity));
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SpawnObj());


        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(aro, aroSpawner.transform.position, Quaternion.Euler(90, 0, 0));
            //dardos
            dardoListaObjs.Add(Instantiate(dardo, dardoSpawner.transform.position, Quaternion.Euler(90, 0, 0)));
            dardoListaObjs1.Add(Instantiate(dardo1, dardoSpawner1.transform.position, Quaternion.Euler(90, 0, 0)));
            //aros
            aroListaObjs.Add(Instantiate(aro, aroSpawner.transform.position, Quaternion.identity));
            aroListaObjs1.Add(Instantiate(aro1, aroSpawner1.transform.position, Quaternion.identity));
            //bolas
            bolasListaObjs.Add(Instantiate(bolas, bolasSpawner.transform.position, Quaternion.identity));
            bolasListaObjs1.Add(Instantiate(aro1, bolasSpawner1.transform.position, Quaternion.identity));
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StopAllCoroutines();
            for (int i = 0; i < aroListaObjs.Count; i++)
            {
                Destroy(aroListaObjs[i]);

            }
            for (int i = 0; i < aroListaObjs1.Count; i++)
            {
                Destroy(aroListaObjs1[i]);

            }

            for (int i = 0; i < dardoListaObjs.Count; i++)
            {
                Destroy(dardoListaObjs[i]);

            }
            for (int i = 0; i < dardoListaObjs1.Count; i++)
            {
                Destroy(dardoListaObjs1[i]);

            }
            for (int i = 0; i < bolasListaObjs.Count; i++)
            {
                Destroy(bolasListaObjs[i]);

            }
            for (int i = 0; i < bolasListaObjs1.Count; i++)
            {
                Destroy(bolasListaObjs1[i]);
            }

            aroListaObjs.Clear();
                aroListaObjs1.Clear();
                dardoListaObjs.Clear();
                dardoListaObjs1.Clear();
                bolasListaObjs.Clear();
                bolasListaObjs1.Clear();



        }

    }
    IEnumerator SpawnObj()
    {
        yield return new WaitForSeconds(1);
        //dardos
        if (CheckDardo())
        {
            Vector3 randomSpawn = new Vector3(Random.Range(dardoBoundSpawn.bounds.min.x, dardoBoundSpawn.bounds.max.x), Random.Range(dardoBoundSpawn.bounds.min.y, dardoBoundSpawn.bounds.max.y), Random.Range(dardoBoundSpawn.bounds.min.z, dardoBoundSpawn.bounds.max.z));
            dardoListaObjs.Add(Instantiate(dardo, randomSpawn, Quaternion.Euler(90, 0, 0)));
        }
        if (CheckDardo1())
        {
            Vector3 randomSpawnDardo1 = new Vector3(Random.Range(dardoBoundSpawn1.bounds.min.x, dardoBoundSpawn1.bounds.max.x), Random.Range(dardoBoundSpawn1.bounds.min.y, dardoBoundSpawn1.bounds.max.y), Random.Range(dardoBoundSpawn1.bounds.min.z, dardoBoundSpawn1.bounds.max.z));
            dardoListaObjs1.Add(Instantiate(dardo1, randomSpawnDardo1, Quaternion.Euler(90, 0, 0)));
        }
        //aros
        if (CheckAro())
        {
            Vector3 randomSpawnAro = new Vector3(Random.Range(aroBoundSpawn.bounds.min.x, aroBoundSpawn.bounds.max.x), Random.Range(aroBoundSpawn.bounds.min.y, aroBoundSpawn.bounds.max.y), Random.Range(aroBoundSpawn.bounds.min.z, aroBoundSpawn.bounds.max.z));
            aroListaObjs.Add(Instantiate(aro, randomSpawnAro, Quaternion.identity));

        }
        if (CheckAro1())
        {
            Vector3 randomSpawnAro1 = new Vector3(Random.Range(aroBoundSpawn1.bounds.min.x, aroBoundSpawn1.bounds.max.x), Random.Range(aroBoundSpawn1.bounds.min.y, aroBoundSpawn1.bounds.max.y), Random.Range(aroBoundSpawn1.bounds.min.z, aroBoundSpawn1.bounds.max.z));
            aroListaObjs1.Add(Instantiate(aro1, randomSpawnAro1, Quaternion.identity));
        }
        if (CheckBola())
        {
            Vector3 randomSpawnBola = new Vector3(Random.Range(bolasBoundSpawn.bounds.min.x, bolasBoundSpawn.bounds.max.x), Random.Range(bolasBoundSpawn.bounds.min.y, bolasBoundSpawn.bounds.max.y), Random.Range(bolasBoundSpawn.bounds.min.z, bolasBoundSpawn.bounds.max.z));
            bolasListaObjs.Add(Instantiate(bolas, randomSpawnBola, Quaternion.identity));

        }
        if (CheckBola1())
        {
            Vector3 randomSpawnBola1 = new Vector3(Random.Range(bolasBoundSpawn1.bounds.min.x, bolasBoundSpawn1.bounds.max.x), Random.Range(bolasBoundSpawn1.bounds.min.y, bolasBoundSpawn1.bounds.max.y), Random.Range(bolasBoundSpawn1.bounds.min.z, bolasBoundSpawn1.bounds.max.z));
            bolasListaObjs1.Add(Instantiate(bolas1, randomSpawnBola1, Quaternion.identity));
        }

        yield return null;
    }
        //Bolas
    private bool CheckDardo()
    {
        if (dardoListaObjs.Count > 19)
        {
            StopAllCoroutines();
            return false;
        }
        return true;
    }
    private bool CheckDardo1()
    {
        if (dardoListaObjs1.Count > 19)
        {
            StopAllCoroutines();
            return false;

        }

        return true;
    }
    private bool CheckAro()
    {
        if (aroListaObjs.Count > 4)
        {
            StopAllCoroutines();
            return false;
        }
        return true;
    }
    private bool CheckAro1()
    {
        if (aroListaObjs1.Count > 9)
        {
            StopAllCoroutines();
            return false;
        }
        return true;
    } 
    private bool CheckBola()
    {
        if (bolasListaObjs.Count > 9)
        {
            StopAllCoroutines();
            return false;
        }
        return true;
    }
    private bool CheckBola1()
    {
        if (bolasListaObjs1.Count > 9)
        {
            StopAllCoroutines();
            return false;
        }
        return true;
    }
}
