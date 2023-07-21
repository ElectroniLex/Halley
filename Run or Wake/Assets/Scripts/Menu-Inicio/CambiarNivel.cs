using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambiarNivel : MonoBehaviour
{
    [SerializeField] GameObject PanelEcenarios;
    [SerializeField] GameObject PanelGlobal;


    public void SeleccionCiudad()
    {
        SceneManager.LoadScene("Escena_calle_01");
        Debug.Log("Abriendo ecenario Ciudad...");
    }
    public void SeleccionBosque()
    {
        //SceneManager.LoadScene("Escenario-Bosque");
        Debug.Log("Abriendo ecenario Bosque...");
    }
    public void SeleccionDesierto()
    {
        //SceneManager.LoadScene("Escenario-Desierto");
        Debug.Log("Abriendo ecenario Desierto...");
    }

    public void AbrirPanelEcenarios()
    {
        PanelEcenarios.SetActive(true);
        PanelGlobal.SetActive(false);
    }
    public void RegresarAlPanelGlobal()
    {
        PanelGlobal.SetActive(true);
        PanelEcenarios.SetActive(false);
    }

    
}
