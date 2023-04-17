using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemigo : MonoBehaviour
{
    NavMeshAgent radar;
    public GameObject jugador;
    float tiempodebusqueda = 10;

    private void Start()
    {
        radar = GetComponent<NavMeshAgent>();
        Recalcular();
        StartCoroutine(Esperaentrecaluclos());
    }
    private void Update()
    {
        RaycastHit hit;
        Vector3 direccion = (transform.position - jugador.transform.position).normalized;
        Debug.DrawRay(transform.position, direccion * 100f, Color.white);
        Debug.Log(jugador.transform.position);
        if (Physics.Raycast(transform.position, direccion, out hit))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Recalcular();


            }

        }


    }

    void Recalcular()
    {



        radar.SetDestination(jugador.transform.position);

    }

    IEnumerator Esperaentrecaluclos()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempodebusqueda);
            Recalcular();
        }

    }
}
