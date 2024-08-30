using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enlaces : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // script que enlazará a sitios web
    public void EnlacesRedes (string enlace)
    {
        Application.OpenURL(enlace);
    }
}
