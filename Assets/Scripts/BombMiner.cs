using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMiner : MonoBehaviour
{
    [SerializeField] private GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(bomb, transform.position + transform.forward, Quaternion.identity);
        }
    }
}
