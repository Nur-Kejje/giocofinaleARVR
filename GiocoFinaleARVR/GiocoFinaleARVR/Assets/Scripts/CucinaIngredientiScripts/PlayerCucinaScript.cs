using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCucinaScript : MonoBehaviour
{
    [SerializeField] private float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }

    private void Movimento()
    {
        float movimentoVerticale = Input.GetAxis("Vertical") * speed;
        float movimentoOrizzontale = Input.GetAxis("Horizontal") * speed;

        if (movimentoVerticale > 0)
        {
            transform.rotation = Quaternion.AngleAxis(0, transform.up);
            transform.Translate(Vector3.forward * movimentoVerticale * Time.deltaTime);
        }
        else if (movimentoVerticale < 0)
        {
            transform.rotation = Quaternion.AngleAxis(180, transform.up);
            transform.Translate(Vector3.back * movimentoVerticale * Time.deltaTime);
        }
        if (movimentoOrizzontale > 0)
        {
            transform.rotation = Quaternion.AngleAxis(90, transform.up);
            transform.Translate(Vector3.forward * movimentoOrizzontale * Time.deltaTime);
        }
        else if (movimentoOrizzontale < 0)
        {
            transform.rotation = Quaternion.AngleAxis(270, transform.up);
            transform.Translate(Vector3.back * movimentoOrizzontale * Time.deltaTime);
        }


    }
}
