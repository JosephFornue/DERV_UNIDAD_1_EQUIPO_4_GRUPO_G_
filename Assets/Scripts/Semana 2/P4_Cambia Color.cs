using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_CambiaColor : MonoBehaviour

{
    Renderer rend;
       [SerializeField] Material Material_1;

       [SerializeField] Material Material_2;

       int estado;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        estado = 0;   
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.F)){
             if(estado == 0){
            estado = 1;
            rend.material = Material_1;    
        }
        else{
            estado = 0;
            rend.material = Material_2;
        }
       }
    }
}
