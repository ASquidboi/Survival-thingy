using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsMeleeReady : MonoBehaviour
{
    public static bool IsColliding = false;
    [SerializeField] private float damage = 50f;
    [SerializeField] private float AttackRate = 1f;
    private float lastAttackTime = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider hitInfo)
    {
        if (Input.GetButton("Fire1") && Time.time > lastAttackTime + AttackRate)
        {
            Debug.Log("asdf");
            lastAttackTime = Time.time;
            Tree tree = hitInfo.GetComponent<Tree>();
            if (tree != null)
            {
                tree.GetHit(damage);
            }
        }
    }
    void OnTriggerExit()
    {
        IsColliding = false;
    }
}
