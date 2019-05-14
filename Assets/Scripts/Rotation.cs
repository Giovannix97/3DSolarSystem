using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject target;
    public float speed;    
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject body = this.gameObject;
        float angle = speed;
        body.transform.RotateAround(target.transform.position, Vector3.up, angle);
    }
}
