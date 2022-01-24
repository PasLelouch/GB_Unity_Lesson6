using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private DoorType Door;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var pc = other.GetComponent<PlayerController>();
            if (pc.HasKey(Door))
            {
                //Open();
                Destroy(gameObject);
            }

        }
    }

    private void Open()
    {

    }
}
