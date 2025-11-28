using UnityEngine;
/*Contenido
Velodidad de la bala
Tiempo de existencia sin colisiones específicas
Condiciones de comparación por colisión por Trigger (Destrucción por única colisión)
*/

public class EnemyOneBullet : MonoBehaviour
{
    public float Speed = 3f;
    void Start()
    {
        Destroy(gameObject, 5);
    }

    void Update()
    {
        transform.position += transform.up * Speed * Time.deltaTime; //DIRECCION VELOCIDAD TIME DELTA TIME
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            Destroy(gameObject);
    }
}
