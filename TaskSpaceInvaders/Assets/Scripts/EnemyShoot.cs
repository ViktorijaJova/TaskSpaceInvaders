using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyShoot : MonoBehaviour
{

    public GameObject secondbullet;
    public float minimumShootDelay = 1.0f;
    public float maximumShootDelay = 10.0f;

    private void Start()
    {
        Invoke("ShootFunction", Random.Range(minimumShootDelay, maximumShootDelay));
        
    }

 

    void ShootFunction()
    {
        Instantiate(secondbullet, transform.position, transform.rotation);
        Invoke("ShootFunction", Random.Range(minimumShootDelay, maximumShootDelay));
    }

}
