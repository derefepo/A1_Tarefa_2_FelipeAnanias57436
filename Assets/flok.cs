using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flok : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(flokmanager.FM.minSpeed,flokmanager.FM.maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
