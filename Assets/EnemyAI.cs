using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float EnemySpeed = 3.0f;
    public GameObject EnemyExplosion;
    void Update()
    {
        transform.Translate(Vector3.down * EnemySpeed * Time.deltaTime);
        if(transform.position.y <= -6.44f)
        {
            float randomX = Random.Range(-7.71f, 7.71f);
            transform.position = new Vector3(randomX, 6.4f, 0f);
        }
      
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "laser")
        {
            Instantiate(EnemyExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (other.tag == "Player")
        {
            player player = other.GetComponent <player> ();
            player.LifeDamageFun();
            
        }
        Instantiate(EnemyExplosion, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }



}
