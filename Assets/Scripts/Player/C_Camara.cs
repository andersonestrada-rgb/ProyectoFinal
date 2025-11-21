using UnityEngine;

public class C_SeguirCamara : MonoBehaviour
{
    public Transform Doro;  
    public float suavizadoDeMovimiento = 5f; 

    void Update()
    {
        if (Doro == null) return;
        Vector2 nuevaPosicion = new Vector2(Doro.position.x, Doro.position.y);
        transform.position = Vector2.Lerp(transform.position, nuevaPosicion, suavizadoDeMovimiento * Time.deltaTime);
    }
}