using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField] private Transform O1;
    [SerializeField] private Transform O2;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float Speed;

    private GameObject _bulletGO;

    // Start is called before the first frame update
    void Start()
    {
        _bulletGO = Instantiate(Bullet, O1.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        //var distance = Vector3.Distance(O1.position, O2.position);
        //var distance = (O2.position - O1.position).magnitude;
        //var dotProduct = Vector3.Dot(O1.position, O2.position);
        //var cross = Vector3.Cross(O1.position, O2.position);

        var direction = O2.position - O1.position;

        //_bulletGO.transform.Translate(O1.forward * Time.deltaTime * Speed);
        //_bulletGO.transform.position = Vector3.MoveTowards(_bulletGO.transform.position, O2.position, Speed * Time.deltaTime);
        //_bulletGO.transform.position = Vector3.Lerp(O1.position, O2.position, 1f);
    }
}
