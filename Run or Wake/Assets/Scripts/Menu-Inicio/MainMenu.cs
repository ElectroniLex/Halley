using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void SeleccionEscenarios()
    {
        SceneManager.LoadScene("SeleccionEscenarios");
    }
}
