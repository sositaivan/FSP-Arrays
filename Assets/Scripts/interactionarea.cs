using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//detectar cuadno el area entra en contacto con un alimetno
//si lo hace destruye el alimetno
//y suma una variable al valor del item
//y muestra el valor 

//agregar variable que almacene el maximo de puntos
//cuando se llegue al maximo no se pueden sumar mas
//mostrar en txtScore el lugar del puntaje un mensaje "ganaste"


public class interactionarea : MonoBehaviour
{
    public Text txtScore;
    public int Score;
    public int maxScore;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    // Update is called once per frame
    private void OnColllisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        Score += alimento.valorAlimentario;
        if(Score < maxScore)
        {
            txtScore.text = Score.ToString();
            Destroy(collision.gameObject);
        }
        else
        {
            txtScore.text = "Ganaste";
        }
    }
}
