using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject cowprefabs;
    [SerializeField] private float time;
    private List<GameObject> cows = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SpawnCows());
    }
    IEnumerator SpawnCows()
    {
        yield return new WaitForSeconds(time);
        SpawnCow();
    }
    void SpawnCow()
    {
        GameObject cow = Instantiate(cowprefabs, transform.position, transform.rotation);
        cow.GetComponent<AnimalDestroyController>().Animal = this;
        cows.Add(cow);
        
    }

    public void DestroyCow(GameObject cow)
    {
        cows.Remove(cow);
    }

}
