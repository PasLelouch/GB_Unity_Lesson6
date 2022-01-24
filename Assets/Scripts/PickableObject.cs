using UnityEngine;

public class PickableObject : MonoBehaviour
{
    [SerializeField] private ObjectType Type;
    [SerializeField] private string Description;

    public string ObjectDescription => Description;
    public ObjectType ObjectType => Type;
}

public enum ObjectType
{
    Key,
    Map,
    Health,
    Patron,
    Fork
}
