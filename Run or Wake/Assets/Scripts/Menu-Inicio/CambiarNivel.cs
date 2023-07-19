using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarNivel : MonoBehaviour
{
    public void SeleccionCiudad()
    {
        SceneManager.LoadScene("Escena_calle_01");
    }
    public void SeleccionBosque()
    {
        SceneManager.LoadScene("Escenario-Bosque");
    }
    public void SeleccionDesierto()
    {
        SceneManager.LoadScene("Escenario-Desierto");
    }
}
