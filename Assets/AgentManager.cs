using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    // Acessar os objetos para obter
    GameObject[] agents;

    // Start is called before the first frame update
    void Start()
    {
        //Encontrar os objetos com a tag AI
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    // Update is called once per frame
    void Update()
    {

        //Verfica se clicar com o botão esquerdo do mouse, ira obter o ponto atraves do raycast pela posição do mouse e passar para cada item da lista
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;

            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach (GameObject a in agents)
                {
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
                }
            }
        }
    }
}
