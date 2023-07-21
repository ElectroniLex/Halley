using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambiarNivel : MonoBehaviour
{
    [SerializeField] GameObject PanelEcenarios;
    [SerializeField] GameObject PanelGlobal;

    [SerializeField] string EcenarioBosque;
    [SerializeField] string EcenarioDesierto;
    [SerializeField] string EcenarioCiudad;

    public void SeleccionCiudad()
    {
        SceneManager.LoadScene(EcenarioCiudad);
        Debug.Log("Abriendo ecenario Ciudad...");
    }
    public void SeleccionBosque()
    {
        SceneManager.LoadScene(EcenarioBosque);
        Debug.Log("Abriendo ecenario Bosque...");
    }
    public void SeleccionDesierto()
    {
        SceneManager.LoadScene(EcenarioDesierto);
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
