using UnityEngine;

public class JitteringMagnitud : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 2f;
    public float accuracy = 0.01f;

    
    void Update()
    {
        Vector3 direction = objetivo.position - transform.position;

        if (direction.magnitude > accuracy)
        {
            transform.LookAt(objetivo);
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
    }
}
