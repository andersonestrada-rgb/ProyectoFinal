using UnityEngine;

/*Contenido
Velodidad de la bala
Tiempo de existencia sin colisiones específicas
Condiciones de comparación por colisión por Trigger (Destrucción por única colisión)
*/

public class Bullet : MonoBehaviour
{   
    public float Speed;

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
        if (collision.CompareTag("Enemy") || collision.CompareTag("EnemyTwo")) //Comparar contacto con los enemigos para destruir la bala
            Destroy(gameObject);
    }
}
