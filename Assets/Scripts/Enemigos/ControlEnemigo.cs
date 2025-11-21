using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform Doro;   
    public float speed = 3f;   

    void Update()
    {
        
        Vector2 direction = (Vector2)Doro.position - (Vector2)transform.position;

        
        direction = direction.normalized;

        
        transform.position = (Vector2)transform.position + direction * speed * Time.deltaTime;
    }
}
