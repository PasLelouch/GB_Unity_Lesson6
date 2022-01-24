using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCol : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        //Проверка тэга объекта
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enemy");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
