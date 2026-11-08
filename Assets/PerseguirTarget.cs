using UnityEngine;

public class PerseguirTarget : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 3f;

    void Update()
    {
        Vector3 direccion = objetivo.position - transform.position;

        Quaternion rotacionObjetivo = Quaternion.LookRotation(direccion);

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            rotacionObjetivo,
            velocidad * Time.deltaTime
        );

        transform.position = Vector3.MoveTowards(
            transform.position,
            objetivo.position,
            velocidad * Time.deltaTime
        );
    }
}
