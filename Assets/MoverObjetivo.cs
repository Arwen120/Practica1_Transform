using UnityEngine;

public class MoverObjetivo : MonoBehaviour
{
    public float velocidad = 3f;

    
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");


        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);

        transform.Translate(movimiento * velocidad * Time.deltaTime, Space.World);
    }
}
