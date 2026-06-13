using UnityEngine;
using TMPro;
using UnityEngine.UI; // Esta línea es nueva, sirve para controlar imágenes

public class ControladorInfoAR : MonoBehaviour
{
    [Header("Componentes de la Interfaz")]
    public GameObject panelInfo;
    public TextMeshProUGUI textoTitulo;
    public TextMeshProUGUI textoDescripcion;
    public Image imagenIcono; // Casilla nueva para el componente de imagen

    [Header("Sprites de los Órganos")]
    public Sprite spriteCorazon;
    public Sprite spritePulmones;

    void Start()
    {
        panelInfo.SetActive(false);
    }

    public void MostrarCorazon()
    {
        panelInfo.SetActive(true);
        imagenIcono.sprite = spriteCorazon; // Cambia el icono al corazón
        textoTitulo.text = "SISTEMA CARDIOVASCULAR: EL CORAZÓN";
        textoDescripcion.text = "Órgano muscular hueco que bombea sangre rica en oxígeno a todo el cuerpo. Consta de cuatro cavidades: dos aurículas y dos ventrículos. Su ciclo incluye sístole (contracción) y diástole (relajación).";
    }

    public void MostrarPulmones()
    {
        panelInfo.SetActive(true);
        imagenIcono.sprite = spritePulmones; // Cambia el icono a los pulmones
        textoTitulo.text = "SISTEMA RESPIRATORIO: LOS PULMONES";
        textoDescripcion.text = "Órganos principales de la respiración encargados del intercambio de gases (hematosis). El pulmón derecho tiene tres lóbulos y el izquierdo dos. Absorben oxígeno y eliminan dióxido de carbono.";
    }

    public void OcultarPanel()
    {
        panelInfo.SetActive(false);
    }
}