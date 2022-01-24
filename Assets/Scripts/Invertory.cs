using System.Collections.Generic;
using UnityEngine;

public class Invertory : MonoBehaviour
{
    private List<InvertoryObject> _objects = new List<InvertoryObject>();

    public List<InvertoryObject> GetInvertoryObjects => _objects;

    public void AddObjectToInvertory(ObjectType type)
    {
        _objects.Add(new InvertoryObject(type));
    }

    public bool HasObject(ObjectType type)
    {
        foreach (var o in _objects)
        {
            if(o.Type == type)
            {
                return true;
            }
        }

        return false;
    }

    public void RemoveObject(ObjectType type)
    {

    }  
}

public class InvertoryObject
{
    public ObjectType Type;

    public InvertoryObject(ObjectType type)
    {
        Type = type;
    }
}
