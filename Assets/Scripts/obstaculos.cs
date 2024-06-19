using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;
    [SerializeField]
    private float variacaoposicaoy;
    [SerializeField]
    private float tempoparadeletar;
    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoposicaoy,variacaoposicaoy));
    }
    void Update()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}
