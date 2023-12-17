using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

    }
    public void OnTriggerEnter(Collider other) {
        print(other);
        //if (other.tag == "Enemy") {
        if(other.GetComponent<Enemy>() != null) {
            Destroy(other);
            Destroy(gameObject);
        }
    }
}
