using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerInc : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    public int PowerIncrId;
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {//access player class and its component(only if component is public)
            player player = other.GetComponent<player>();
            if (player!=null)
            {
                //enable the triple shot
                // player.IsTripleShot = true; //instead of player.TripleShotOn();
                if (PowerIncrId == 0)
                {
                    player.TripleShotOn();
                }
                else if (PowerIncrId == 1)
                {
                    // player.PowerSpeedUp = true;
                    player.PowerSpeedON();
                }
                else if (PowerIncrId == 2)
                {
                    //for shield
                    player.EnableShield();
                }
                //destroy themself
                Destroy(this.gameObject);
            }
            
        }
    }
}
