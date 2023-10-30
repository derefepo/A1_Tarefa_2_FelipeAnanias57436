using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flokmanager : MonoBehaviour
{
    public static flokmanager FM;
    public GameObject fishPrefab;
    public int numfish = 20;
    public GameObject[] allfish;
    public Vector3 swimlimits = new Vector3(5,5,5);

    [Header("Fish Settings")]
    [Range(0.0f, 5.0f)]
    public float minSpeed;
    [Range(0.0f,5.0f)]
    public float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        allfish = new GameObject[numfish];
        for(int i = 0;i < numfish; i++)
        {
            Vector3 pos = this.transform.position + new Vector3(Random.Range(-swimlimits.x,swimlimits.x),
                                                                Random.Range(-swimlimits.y, swimlimits.y),
                                                                Random.Range(-swimlimits.z, swimlimits.z));
            allfish[i] = Instantiate(fishPrefab, pos, Quaternion.identity);
        }
        FM = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
