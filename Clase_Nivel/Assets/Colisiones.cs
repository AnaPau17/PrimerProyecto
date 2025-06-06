using UnityEngine;

public class Colisiones : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //estados colision
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo")){
            Debug.Log("¡Colisión Iniciada con: " + collision.gameObject.name + "!");
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo")){
            Debug.Log("Colisión Manteniendose con: " + collision.gameObject.name);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo")){
            Debug.Log("¡Colisión Finalizada con: " + collision.gameObject.name + "!");
        }
    }
}
