using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moedas : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D (Collision2D outro){
        //void OnTriggerEnter2D (Collision2D outro)
        //pontuacao.pontos=pontuacao.pontos+1;
        Destroy(gameObject);

    }
}
