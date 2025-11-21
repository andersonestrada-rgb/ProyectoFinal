using UnityEngine;

//DIRECCION VELOCIDAD TIME DELTA TIME
public class Bullet : MonoBehaviour
{
    public float Speed;
    void Start()
    {       
        Destroy(gameObject, 5);
    }


    void Update()
    {
        transform.position += transform.up * Speed * Time.deltaTime;
    }    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player" && collision.tag != "Bullet") 
        Destroy(gameObject);
    }

}
