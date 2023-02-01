using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{

    public Transform siguientePunto; 


    public Transform [] puntoruta;
    
    
    [Range(0f,2f)]
    public float Tamanopunto=1f;



    public void OnDrawGizmos()
    {
        if (puntoruta.Length>0)
        {
            for(int i =0; i < puntoruta.Length; i++)
            {
               if (i==0)
               {
                
                Gizmos.color=Color.blue;

               }
               else 
               {
                 Gizmos.color=Color.green;
               }

               Gizmos.DrawWireSphere(puntoruta[i].position,Tamanopunto);

            }

            for(int i =0; i < puntoruta.Length-1; i++)
            {
               Gizmos.color=Color.red;
               Gizmos.DrawLine(puntoruta[i].position,puntoruta[i+1].position);
                
            }
            Gizmos.DrawLine(puntoruta[puntoruta.Length-1].position,puntoruta[0].position);

        }
        

    }

    

}
