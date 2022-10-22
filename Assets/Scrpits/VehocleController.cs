using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class VehocleController : MonoBehaviour
{
    public Rigidbody2D Ftire;
    public Rigidbody2D Btire;
    public float speed;
    public float movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Btire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        Ftire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        
    }
}
