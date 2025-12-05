using System.Collections.Generic;
using UnityEngine;
/*Contenido
Velodidad de la bala
Tiempo de existencia sin colisiones específicas
Condiciones de comparación por colisión por Trigger (Destrucción por única colisión)
*/

public class EnemyOneBullet : MonoBehaviour
{
    [SerializeField] private PlayerController playerController; //Referencia a PlayerController para acceder al método de vida
    [SerializeField] private float Speed = 3f;
    [SerializeField] private float Damage = 10f;
    [SerializeField] private float DestroyBullet = 5f;
    private List <string> tagslistE = new List<string>
    {     "Player", "ShotPlayer" };

    void Start()
    {
        Destroy(gameObject, DestroyBullet);
    }

    void Update()
    {
        transform.position += transform.up * Speed * Time.deltaTime; //DIRECCION VELOCIDAD TIME DELTA TIME
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (string tag in tagslistE)        
        {           
            if (collision.CompareTag(tag))
            {
                Destroy(gameObject);
                if (collision.CompareTag("Player"))
                {
                    playerController.PlayerLife(Damage); //Causar daño al jugador al colisionar con la bala
                }                
            }
        }
    }
}
