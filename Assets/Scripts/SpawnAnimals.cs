using System.Collections;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    [SerializeField] private GameObject[] _animals;   
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _spawnInterval;

    private void Start() 
    {
        StartCoroutine(StartSpawnAnimals());    
    }

    private IEnumerator StartSpawnAnimals()
    {
        while(true)
        {
            yield return new WaitForSeconds(_spawnInterval);

            int animalIndex = Random.Range(0, _animals.Length);
            GameObject animal = _animals[animalIndex];

            int spawnIndex = Random.Range(0, _spawnPoints.Length);
            Transform spawnPoint = _spawnPoints[spawnIndex];

            Instantiate(animal, spawnPoint.position, animal.transform.rotation);
        }
    }
}
