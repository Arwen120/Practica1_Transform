using UnityEngine;

public class JitteringDistancia : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 2f;
    public float accuracy = 0.01f;

    
    void Update()
    {
        float distancia = Vector3.Distance(transform.position, objetivo.position);

        if(distancia > accuracy)
        {
            transform.LookAt(objetivo);
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
    }
}
