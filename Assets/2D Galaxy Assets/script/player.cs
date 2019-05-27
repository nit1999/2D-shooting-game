using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    
    private float speed = 5f;
    private float speedUp = 12f;
    public int LifeDamage = 3;
    public bool IsTripleShot=false;
    public GameObject playerExplosionPrefab;
   public GameObject laserPrefab;
  
   public GameObject RightLaserPrefab;
   
    public GameObject LeftLaserPrefab;
    // private GameObject TripleShotLaser;

    public bool IsPowerSpeedUp=false;

    void Start()
    {
       /* transform.position = new Vector3(1, 1,0);
        Debug.Log("name of object=" + name);
        */
    }

    
    void Update()
    {
         movement();
       if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab,transform.position + new Vector3(0f, 1f, 0f),Quaternion.identity);
        }
      
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (IsTripleShot == true)
            { // Instantiate(laserPrefab, transform.position, Quaternion.identity);
                //center laser prefab
              Instantiate(laserPrefab, transform.position + new Vector3(0f, 4f, 0f), Quaternion.identity);
                //right laser prefab
                  Instantiate(RightLaserPrefab, transform.position + new Vector3(0.65f, -0.2f, 0f), Quaternion.identity);
                //left laser prefab
                 Instantiate(LeftLaserPrefab, transform.position + new Vector3(-0.65f, -0.2f, 0f), Quaternion.identity);
            }
        }
    }

    private void movement()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        if (IsPowerSpeedUp != true) {
            transform.Translate(Vector3.right * speed * horizontalMove * Time.deltaTime);
            transform.Translate(Vector3.up * speed * verticalMove * Time.deltaTime);
        }
        else if(IsPowerSpeedUp == true)
        {
            transform.Translate(Vector3.right * speedUp * horizontalMove * Time.deltaTime);
            transform.Translate(Vector3.up * speedUp * verticalMove * Time.deltaTime);
        }
        
        if (transform.position.x > 9.52)
        {
            transform.position = new Vector3(-9.52f, transform.position.y, 0f);
        }

        else if (transform.position.x < -9.52)
        {
            transform.position = new Vector3(9.52f, transform.position.y, 0f);
        }

        if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0f, 0f);
        }
        else if (transform.position.y < -4.14f)
        {
            transform.position = new Vector3(transform.position.x, -4.14f, 0f);
        }
    }

    public void TripleShotOn()
    {
        IsTripleShot = true;
        StartCoroutine(TripleShotPowerDownCoroutine());
    }
   public  IEnumerator TripleShotPowerDownCoroutine()
    {
        yield return new WaitForSeconds(5f);
        IsTripleShot = false;
    }

    public void PowerSpeedON()
    {
        StartCoroutine(PowerSpeedDecCoroutine());
        IsPowerSpeedUp = true;
    }
    public IEnumerator PowerSpeedDecCoroutine()
    {
        yield return new WaitForSeconds(5f);
        IsPowerSpeedUp = false;

    }

   public void LifeDamageFun()
    {
        LifeDamage--;
        if(LifeDamage < 1)
        {
            Instantiate(playerExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
