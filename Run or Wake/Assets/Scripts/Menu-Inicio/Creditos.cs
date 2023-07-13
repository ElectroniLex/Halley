using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Creditos : MonoBehaviour
{
    void Start()
    {
        Invoke("WaitToEnd", 10);
    }


    public void WaitToEnd()
    {
        SceneManager.LoadScene("MenuPrincipal2");
    }
}