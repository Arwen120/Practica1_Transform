using UnityEngine;


public class GiroSuave : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 2f;

    void Update()
    {
        Vector3 direccion = objetivo.position - transform.position;

        Quaternion rotacionObjetivo = Quaternion.LookRotation(direccion);

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            rotacionObjetivo,
            velocidad * Time.deltaTime
        );

        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}
