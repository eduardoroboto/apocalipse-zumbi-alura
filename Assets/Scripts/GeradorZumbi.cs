using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbi : MonoBehaviour
{

    public GameObject Zumbi;
    public float TempoGerarZumbi = 1;
    private float contadorTempo = 0;

    // Update is called once per frame
    void Update()
    {
        contadorTempo += Time.deltaTime;
        if(contadorTempo >= TempoGerarZumbi)
        {
        Instantiate(Zumbi, transform.position, transform.rotation);
        contadorTempo = 0;
        }
    }
}
