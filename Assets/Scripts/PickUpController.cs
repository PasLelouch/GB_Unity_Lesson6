using UnityEngine;

[RequireComponent(typeof(Invertory))]
public class PickUpController : MonoBehaviour
{
    private Vector3 _rayStartPos = new Vector3(Screen.width / 2, Screen.height / 2, 0);
    private PickableObject _pickableObject;
    private Invertory _inventory;


   void Awake()
   {
        _inventory = GetComponent<Invertory>();
   }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (CanPickUpObject())
            {
                _inventory.AddObjectToInvertory(_pickableObject.ObjectType);
                Destroy(_pickableObject.gameObject);
                foreach(var o in _inventory.GetInvertoryObjects)
                {
                    Debug.Log(o.Type);
                }
                _pickableObject = null;
            }
        }
    }

    void FixedUpdate()
    {
        if (ReleaseRay(out var go))
        {
            if (go.TryGetComponent<PickableObject>(out var picableObject))
            {
                Debug.Log(picableObject.ObjectDescription);
                _pickableObject = picableObject;
            }
            else
            {
                _pickableObject = null;
            }   
        }
    }

    private bool ReleaseRay(out GameObject go)
    {
        // Сам луч
        Ray ray = Camera.main.ScreenPointToRay(_rayStartPos);
        // Запись объекта, в который пришел луч, в переменную
        Physics.Raycast(ray, out var hit);
        if (hit.collider != null)
        {
            go = hit.collider.gameObject;
            return true;
        }
        go = null;
        return false;
    }

    public bool CanPickUpObject()
    {
        if(_pickableObject != null)
        {
            if (Vector3.Distance(_pickableObject.transform.position, transform.position) <= 5f)
            {
                return true;
            }
        }
        return false;
    }
}
