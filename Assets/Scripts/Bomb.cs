using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float Damage;
    [SerializeField] private float DamageAdditional;
    [SerializeField] private float TimeC;
    private float radius = 5.0F;
    private float power = 100.0F;

    private float _currentTimeIn;

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag != "Player")
        { 
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
               
            }
               
        }
        var hc = other.GetComponent<EnemyHealth>();
        hc.CurrentHealth -= Damage;
        Debug.Log(hc.CurrentHealth);
        Destroy(gameObject);
        }


        /*   if (other.CompareTag("Player"))
           {
               var hc = other.GetComponent<HealthController>();
               hc.CurrentHealth -= Damage;
               Debug.Log(hc.CurrentHealth);
               other.GetComponent<Rigidbody>().AddExplosionForce(power, other.gameObject.transform.position, radius, 3.0f);
               Destroy(gameObject);
           }*/
    }

    /* void OnTriggerStay(Collider other)
     {
         if (other.CompareTag("Player"))
         {
             _currentTimeIn += Time.deltaTime;
             if(_currentTimeIn >= TimeC)
             {
                 var hc = other.GetComponent<HealthController>();
                 hc.CurrentHealth -= DamageAdditional;
                 Debug.Log(hc.CurrentHealth);
                 _currentTimeIn = 0;
             }
         }
     }

     void OnTriggerExit(Collider other) 
     {
         if (other.CompareTag("Player"))
         {
             _currentTimeIn = 0;
         }
     } */
}
