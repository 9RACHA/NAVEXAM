using UnityEngine;
using UnityEngine.AI;

public class PersigoLento : MonoBehaviour {

   public Transform Objetivo;

    //Al incrementar la velocidad el comportamiento se vuelve mas erratico, solo mejora en las rectas
     public float speed = 1f;

   void Start () {
      NavMeshAgent agent = GetComponent<NavMeshAgent>();
      agent.destination = Objetivo.position;

      agent.speed = speed; // Incrementa la velocidad del agente
   }
}
