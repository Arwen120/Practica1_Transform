using UnityEngine;

public class SeguirObjetivoForward : MonoBehaviour
{

    public Transform objetivo;
    public float velocidad = 2f;
    
    void Update()
    {
        transform.LookAt(objetivo);

        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}
