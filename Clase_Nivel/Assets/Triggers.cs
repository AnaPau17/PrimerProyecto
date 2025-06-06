using UnityEngine;

public class Triggers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //triggers
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo")){
            Debug.Log("Trigger Finalizada con: " + collision.gameObject.name + "!");
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo")){
            Debug.Log("Trigger Manteniendose con: " + collision.gameObject.name + "!");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo")){
            Debug.Log("Trigger Finalizado con: " + collision.gameObject.name + "!");
        }
    }
}
