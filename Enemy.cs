using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject target;
    public int playerDamage;
    //public string sceneName = "Level_1";
    // Start is called before the first frame update
    void Start()
    {
        //target.GetComponent<Transform>;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        transform.LookAt(target.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() != null) {
            
            Player player = other.GetComponent<Player>();
            player.TakeDamage(playerDamage);
            if (player.health < 1)
            {
                EditorSceneManager.LoadScene("Level_1");
            }}
    }
}
