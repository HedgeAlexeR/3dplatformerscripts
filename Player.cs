using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    public int health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int numberCoinss = 0;
    public TextMeshProUGUI TextHealth;
    public TextMeshProUGUI TextCoins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextHealth.text = "Health: " + health;
        TextCoins.text = "Coins: " + numberCoinss;
        if (Input.GetMouseButtonDown(0))
            {
                Instantiate(fireballPrefab, 
                attackPoint.
                position, attackPoint.
                rotation);
            }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
