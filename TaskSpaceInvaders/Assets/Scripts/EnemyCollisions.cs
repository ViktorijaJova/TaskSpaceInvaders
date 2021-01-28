using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollisions : MonoBehaviour
{
    public GameObject gamehandler;
    public GameObject explosion;
    public GameObject soundManager;
    private void OnTriggerEnter(Collider colObj)
    {
        if(colObj.gameObject.tag == "Bullet")
        {
           soundManager.SendMessage("PlayExplosionSound");
           gamehandler.SendMessage("EnemyDownCounter");
            GameObject newExplosion = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(newExplosion, 2);
            Destroy(gameObject);
            Destroy(colObj.gameObject);
              
        }

        if(colObj.gameObject.name == "Player")
        {
            Destroy(colObj.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
