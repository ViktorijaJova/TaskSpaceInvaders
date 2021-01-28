using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button reset;

    public void Restart()
    {
        SceneManager.LoadScene("Win");
    }

    void Start()
    {
        reset.onClick.AddListener(() => Restart());
        
    }

}
