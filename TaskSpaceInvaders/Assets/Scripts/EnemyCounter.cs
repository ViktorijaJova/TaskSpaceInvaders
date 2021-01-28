using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    public int enemyCounter;
    public Button reset;



    public void EnemyDownCounter()
    {
        enemyCounter++;
        if(enemyCounter == 22)
        {
            SceneManager.LoadScene("SpaceInvaders");

        }

    }

   
}
