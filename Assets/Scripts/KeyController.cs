using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField] private DoorType Door;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var pc = other.GetComponent<PlayerController>();
            pc.GiveKey(Door);
            Destroy(gameObject);
        }
    }
}
