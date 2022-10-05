using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public float Velocidade = 20;

    void FixedUpdate()
    {
        Vector3 posicaoAtual = GetComponent<Rigidbody>().position;
        Vector3 direcaoDaBala = transform.forward;
        GetComponent<Rigidbody>().MovePosition(posicaoAtual + direcaoDaBala * Velocidade * Time.deltaTime);
    }
}
