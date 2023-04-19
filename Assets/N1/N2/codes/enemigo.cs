using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemigo : MonoBehaviour
{
    NavMeshAgent radar;
    public GameObject jugador;
    float tiempodebusqueda = 1;
    Animator anim;
    Transform player;

    private void Start()
    {
        anim = GetComponent<Animator>();
        radar = GetComponent<NavMeshAgent>();
        Recalcular();
        StartCoroutine(Esperaentrecaluclos());
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }
    private void Update()
    {
        RaycastHit hit;
        Vector3 direccion = (transform.position - jugador.transform.position).normalized;
        Debug.DrawRay(transform.position, direccion * 1000f, Color.white);
        Debug.Log(jugador.transform.position);
        if (Physics.Raycast(transform.position, direccion, out hit))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Recalcular();


            }

        }


        if (Vector3.Distance(transform.position,player.position) <= radar.stoppingDistance + 0.5f)
        {
            anim.SetBool("matar",true);


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