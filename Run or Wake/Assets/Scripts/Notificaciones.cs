using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notificaciones : MonoBehaviour
{
    [SerializeField] GameObject PanelNotificacionSalir;
    
    //Notificacion Salir
    public void Abrir_PanelSalir()
    {
        PanelNotificacionSalir.SetActive(true);

    }
    public void Cerrar_PanelSalir()
    {
        PanelNotificacionSalir.SetActive(false);

    }

    public void Boton_NO()
    {
        Cerrar_PanelSalir();
    }
    public void Boton_SI()
    {
        Application.Quit();
        Debug.Log("Salio del juego");
    }
}
