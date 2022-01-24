using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Turrel : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float Force;
    [SerializeField] private Transform _target;
    public UnityEvent OnPlayerEnter;
    public Transform PositionBullet;
    private Vector3 _playerPosition;
    private bool _isPlyaerInside;

    private float coolDown = 3f;
    private float currentTime = 0;

    void Start()
    {
        StartCoroutine(BulleySpawn(coolDown));
      //  OnPlayerEnter.AddListener();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = _target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        transform.rotation = rotation;

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _playerPosition = other.gameObject.transform.position;
            _isPlyaerInside = true;
            OnPlayerEnter.Invoke();
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            _playerPosition = other.gameObject.transform.position;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _isPlyaerInside = false;
        }
    }

    IEnumerator BulleySpawn(float spawnTime)
    {
        while (true)
        {
            if (_isPlyaerInside)
            {
                var bulletGo = Instantiate(Bullet, transform.position + transform.forward, Quaternion.identity).GetComponent<Rigidbody>();
                bulletGo.AddForce((_playerPosition - transform.position) * Force, ForceMode.Impulse);
            }

            yield return new WaitForSeconds(spawnTime);
        }
    }

    public void BulletSpawn()
    {
        var bulletGo = Instantiate(Bullet, transform.position + transform.forward, Quaternion.identity).GetComponent<Rigidbody>();
        bulletGo.AddForce((_playerPosition - transform.position) * Force, ForceMode.Impulse);
    }
}
