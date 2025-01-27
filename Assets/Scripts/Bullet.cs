using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
   [SerializeField] private float _bulletSpeed = 5;

    void Update()
    {
        transform.position += transform.forward *_bulletSpeed * Time.deltaTime; 
    }


    void OnTriggerEnter(Collider collider)
     {
        if(collider.CompareTag("Player"))
        {
            return;
        }

        gameObject.SetActive(false);
     }
}
