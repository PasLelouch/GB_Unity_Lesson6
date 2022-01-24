using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhosty : MonoBehaviour
{
    public Transform Position;
    public GameObject GhostPrefab;

    void Start()
    {
        var g02 = Instantiate(GhostPrefab, Position.position, Quaternion.identity);
    }
}
