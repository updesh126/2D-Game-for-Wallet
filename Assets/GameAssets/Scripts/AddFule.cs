using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFule : MonoBehaviour
{
    // Start is called before the first frame update
    public CarController carController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        carController.fuel = 1;
        Destroy(gameObject);
    }
}
