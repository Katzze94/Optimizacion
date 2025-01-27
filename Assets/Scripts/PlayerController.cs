using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 
    [SerializeField] private Transform _bulletSpawn;

    [SerializeField] private int _ammoType = 0;









    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
       GameObject bullet = poolManager.Instance.GetPooledObjects(_ammoType,_bulletSpawn.position, _bulletSpawn.rotation);

       if(bullet !=null)
       {
        bullet.SetActive(true);
       }
       else{
        Debug.Log("Pool chikito");
       }
        
    }
}
