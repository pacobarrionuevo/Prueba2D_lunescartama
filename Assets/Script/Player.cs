using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int totalAlumnos = 4;

    // Start is called before the first frame update
    void Start()
    {
        int multiplicacion = totalAlumnos * 3;
        Debug.Log(multiplicacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
