using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Circle : Form
{
    // POLYMORPHISM
    public override void MoveForm()
    {
        transform.position -= Vector3.right;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
