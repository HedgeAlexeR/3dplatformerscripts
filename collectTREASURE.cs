using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectTREASURE : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Player>().numberCoinss += 5;
        print(other.GetComponent<Player>().numberCoinss);
        Destroy(gameObject);
    }
}
