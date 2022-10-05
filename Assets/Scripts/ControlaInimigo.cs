using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo : MonoBehaviour
{

    public GameObject Jogador;
    public float Velocidade = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Vector3 posicaoAtual = GetComponent<Rigidbody>().position;
        Vector3 posicaoJogador = Jogador.transform.position;
        Vector3 posicaoInimigo = transform.position;

        float distancia = Vector3.Distance(posicaoInimigo, posicaoJogador);

        if (distancia > 2.5)
        {
            Vector3 direcao = posicaoJogador - posicaoInimigo;
            GetComponent<Rigidbody>().MovePosition(posicaoAtual + direcao.normalized * Velocidade * Time.deltaTime);

            Quaternion novaRotacao = Quaternion.LookRotation(direcao);
            GetComponent<Rigidbody>().MoveRotation(novaRotacao);

        }

    }

}
