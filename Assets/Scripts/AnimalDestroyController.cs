using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalDestroyController : MonoBehaviour
{
    public AnimalSpawner Animal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnDestroy()
    {
        Animal.DestroyCow(gameObject);
    }

    public void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
