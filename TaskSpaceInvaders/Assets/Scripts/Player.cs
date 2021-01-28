using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    public GameObject soundManager;
    private CharacterController playerController;
    private Vector3 movmenet = Vector3.zero;

    void Start()
    {
        playerController = GetComponent<CharacterController>();    
    }

    void Update()
    {
        movmenet = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        movmenet = transform.TransformDirection(movmenet);
        playerController.Move(movmenet * Time.deltaTime * 50);
        if (Input.GetKeyDown("space"))
        {
         soundManager.SendMessage("PlayBulletSound");
            GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            newBullet.GetComponent<Rigidbody>().AddForce(Vector3.up * 2000);
            Destroy(newBullet, 3); 
        }
    }
}
