using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public T Instance
    {
        get
        {
            if(instance == null)
            {
                instance  = FindObjectOfType<T>();
                if(instance == null)
                    instance = new GameObject(typeof(T) + "Singleton Instance ").AddComponent<T>();
            }
            return instance;
        }
    }

    public virtual void Awake() 
    {
        if(instance != null)
            Destroy(this.gameObject);
    }
}