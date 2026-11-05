using UnityEngine;

public class JitteringMoveTowards : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 2f;

    void Update()
    {
        transform.LookAt(objetivo);

        transform.position = Vector3.MoveTowards(
            transform.position,
            objetivo.position,
            velocidad * Time.deltaTime
            );
    }
}
