using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>()!= null) {
            other.GetComponent<Player>().numberCoinss += 1;
            print(other.GetComponent<Player>().numberCoinss);
            Destroy(gameObject); }
    }
}
