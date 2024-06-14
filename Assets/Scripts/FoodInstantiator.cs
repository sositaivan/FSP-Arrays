using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//agregar variable que establesca la cantidad de veces que se instanicara un alimaneto 
//cuando se instancien esa cantidad de aimentos no deben instanciarse mas
public class FoodInstantiator : MonoBehaviour
{
    public GameObject[] alimentos;
    public Transform clonePoint;
    public float interval;
    public RandomPlacement posicionAleatoria;
    public int maxClones;
    public int cloneCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneFood),0,interval);
    }

    
    void CloneFood()
    {
        if (cloneCount < maxClones)
        {
            cloneCount++;
            posicionAleatoria.SetRandomPosition();
            GameObject prefab = alimentos[Random.Range(0, alimentos.Length)];
            Instantiate(prefab, clonePoint.position, clonePoint.rotation);
        }
    }
}
