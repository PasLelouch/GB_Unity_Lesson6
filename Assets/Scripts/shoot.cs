using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class shoot : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float Force;
    private Vector3 _shoot;

    private float coolDown = 3f;
    private float currentTime = 0;

    void Start()
    {

        //  OnPlayerEnter.AddListener();
    }

    // Update is called once per frame
    void Update()
    {
       
     
    if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            BulletSpawn();

        }


    }

    

   

    public void BulletSpawn()
    {
        var bulletGo = Instantiate(Bullet, transform.position + transform.forward, Quaternion.identity).GetComponent<Rigidbody>();
        bulletGo.AddForce(transform.forward * Force, ForceMode.Impulse);
    }
}
