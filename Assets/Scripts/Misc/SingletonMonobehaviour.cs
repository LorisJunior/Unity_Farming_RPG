using UnityEngine;

public abstract class SingletonMonobehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public T Instance 
    { 
        get
        {
            return instance;
        }
    }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
