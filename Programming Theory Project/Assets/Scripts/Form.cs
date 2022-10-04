using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION
public abstract class Form : MonoBehaviour
{

    // ENCAPSULATION
    public float size
    {
        set
        {
            if(value > 0)
            {
                transform.localScale = new Vector3( value, value, value);
            }
        }

        get
        {
            return transform.localScale.x;
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public abstract void MoveForm();

}
