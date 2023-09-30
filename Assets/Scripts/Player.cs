using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float Health = 100f;
    [SerializeField] private float Hunger = 100f;
    [SerializeField] private float Stamina = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if(Health <= 0f) {
            Die();
        }
    }

    void Die()
    {
        //death and taxes
        Debug.Log("death and taxes");
        Destroy(gameObject);
    }
}
