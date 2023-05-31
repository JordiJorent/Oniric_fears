using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemigo : MonoBehaviour
{
    public NavMeshAgent radar;
    public Animator anim;
    public GameObject jugador;
    float tiempodebusqueda = 1;

    private void Start()
    {
        jugador = GameObject.Find("FirstPersonControllerN2");
        Recalcular();
        StartCoroutine(Esperaentrecaluclos());
    }
    private void Update()
    {
        RaycastHit hit;
        Vector3 direccion = (transform.position - jugador.transform.position).normalized;
        if (Physics.Raycast(transform.position, direccion, out hit))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Recalcular();


            }
        }
        if(Vector3.Distance(transform.transform.position, jugador.transform.position) <= radar.stoppingDistance)
        {
            // ANIMACION MATAR
            anim.SetBool("m", true);
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
