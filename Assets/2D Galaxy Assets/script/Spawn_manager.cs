using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_manager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject PowerUp;
    public GameObject SpeedUp;
    public GameObject ShieldProtect;

    void Start()
    {
  
       StartCoroutine(PowerUpCoroutine());
        StartCoroutine(EnemyCoroutine());
        StartCoroutine(SpeedUpCoroutine());
        StartCoroutine(ShieldCoroutine());

    }
   IEnumerator EnemyCoroutine()
    {
        while (true)
        {
            Instantiate(EnemyPrefab, new Vector3(Random.Range(-7.71f, 7.71f), 6.4f, 0f), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
  
    IEnumerator PowerUpCoroutine()
    {
      while (true)
       {
            Instantiate(PowerUp, new Vector3(Random.Range(-7.71f, 7.71f), 6.4f, 0f), Quaternion.identity);
            yield return new WaitForSeconds(10.0f);
            
        }
    }

    IEnumerator SpeedUpCoroutine()
    {
        while (true)
        {
            Instantiate(SpeedUp, new Vector3(Random.Range(-7.71f, 7.71f), 6.4f, 0f), Quaternion.identity);
            yield return new WaitForSeconds(8.0f);
           
        }
    }

    IEnumerator ShieldCoroutine()
    {
        while (true)
        {
            Instantiate(ShieldProtect, new Vector3(Random.Range(-7.71f, 7.71f), 6.4f, 0f), Quaternion.identity);
            yield return new WaitForSeconds(12.0f);
            
        }
    }
  
   
}
