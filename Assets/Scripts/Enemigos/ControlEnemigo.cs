using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    public GameObject player;   // Referencia al Player
    public float speed = 3f;   // Velocidad del enemigo

    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");        
    }    
}