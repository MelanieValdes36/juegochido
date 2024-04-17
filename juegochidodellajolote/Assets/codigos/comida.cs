using UnityEngine;

public class comida : MonoBehaviour
{
    public float fadeSpeed = 1.0f; // Velocidad de desvanecimiento

    private Material material; // Material de la imagen
    private float currentFade = 1.0f; // Opacidad actual

    void Start()
    {
        // Asegúrate de que tienes un material y que es un material con transparencia
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null && renderer.material != null && renderer.material.HasProperty("_Color"))
        {
            material = renderer.material;
        }
        else
        {
            Debug.LogError("No se encontró un material válido con transparencia en el objeto.");
            enabled = false;
        }
    }

    void Update()
    {
        // Reducir gradualmente la opacidad horizontalmente
        currentFade -= fadeSpeed * Time.deltaTime;
        currentFade = Mathf.Clamp01(currentFade);

        // Aplicar el desvanecimiento al material
        if (material != null)
        {
            material.color = new Color(material.color.r, material.color.g, material.color.b, currentFade);
        }
    }
}