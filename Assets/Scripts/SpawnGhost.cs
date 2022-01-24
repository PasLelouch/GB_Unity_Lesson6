using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhost : MonoBehaviour
{
    public Transform Position;
    public GameObject GhostPrefab;

   
    void Start()
    {
        var g01 = Instantiate(GhostPrefab, Position.position, Quaternion.identity);
    }
}
