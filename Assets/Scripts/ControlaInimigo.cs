using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo : MonoBehaviour
{

    public GameObject Jogador;
    public float Velocidade = 5;

    private Rigidbody rigidbodyInimigo;
    private Animator animatorInimigo;

    private ControlaJogador controlaJogador;

    // Start is called before the first frame update
    void Start()
    {
        Jogador = GameObject.FindWithTag("Jogador");
        int geraTipoZumbi = Random.Range(1,28);
        transform.GetChild(geraTipoZumbi).gameObject.SetActive(true);

        rigidbodyInimigo = GetComponent<Rigidbody>();
        animatorInimigo = GetComponent<Animator>();

        controlaJogador = Jogador.GetComponent<ControlaJogador>();

    }

    void FixedUpdate()
    {
        float distancia = Vector3.Distance(transform.position, Jogador.transform.position);
        Vector3 direcao = Jogador.transform.position - transform.position;
        Quaternion novaRotacao = Quaternion.LookRotation(direcao);
        rigidbodyInimigo.MoveRotation(novaRotacao);

        if (distancia > 2.5)
        {
            rigidbodyInimigo.MovePosition(rigidbodyInimigo.position + direcao.normalized * Velocidade * Time.deltaTime);
            animatorInimigo.SetBool("Atacando", false);
        }
        else
        {
            animatorInimigo.SetBool("Atacando", true);
        }

    }

    void AtacaJogador()
    {
        Time.timeScale = 0;
        controlaJogador.TextoGameOver.SetActive(true);
        controlaJogador.Vivo = false;
    }

}
