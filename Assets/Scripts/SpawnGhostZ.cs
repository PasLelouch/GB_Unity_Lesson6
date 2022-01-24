using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhostZ : MonoBehaviour
{
    public Transform Position;
    public GameObject GhostPrefab;

    void Start()
    {
        var g03 = Instantiate(GhostPrefab, Position.position, Quaternion.identity);
    }
}
