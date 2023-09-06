using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    public GameObject pooledObject;
    public int poolSize = 10;

    private List<GameObject> pooledObjects;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        pooledObjects = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetFromPool()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                pooledObjects[i].SetActive(true);
                return pooledObjects[i];
            }
        }

        return null;
    }

    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
    }
}