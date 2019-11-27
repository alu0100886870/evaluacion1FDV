using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCalavera : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject personaje;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colisionado con: " + other.gameObject);
        if (other.gameObject == personaje)
        {
            personaje.GetComponent<PersonajeMovimiento>().sobreCaca();
            personaje.GetComponent<StatusPerso>().damage();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == personaje)
        {
            personaje.GetComponent<PersonajeMovimiento>().abandonaCaca();
        }
    }
}
