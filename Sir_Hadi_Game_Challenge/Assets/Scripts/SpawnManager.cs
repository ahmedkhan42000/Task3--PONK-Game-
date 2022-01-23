using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ObjectsPrefabs;
    public int ObjectIndex;
    private float SpawnPOS;
    private int StartTime =2;
    private int DelayTime = 10;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects",StartTime,DelayTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnObjects()
    {
        //ObjectIndex = Random.Range(0, ObjectsPrefabs.Length);
        SpawnPOS = Random.Range(-6, 6);
        //Instantiate(ObjectsPrefabs[ObjectIndex], new Vector3(SpawnPOS, 12, -1f), ObjectsPrefabs[ObjectIndex].transform.rotation);
        Instantiate(ObjectsPrefabs[1], new Vector3(SpawnPOS, 12, -1f), ObjectsPrefabs[1].transform.rotation);
    }
}
