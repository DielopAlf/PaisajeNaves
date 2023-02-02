using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{



    public Transform [] puntosruta;
    
    
    [Range(0f,2f)]
    public float Tamanopunto=1f;



    public void OnDrawGizmos()
    {
        if(puntosruta!=null && puntosruta.Length>0)
        {
            for(int i =0; i < puntosruta.Length; i++)
            {
               if (i==0)
               {
                
                Gizmos.color=Color.blue;

               }
               else 
               {
                 Gizmos.color=Color.green;
               }

               Gizmos.DrawWireSphere(puntosruta[i].position,Tamanopunto);

            }

            for(int i =0; i < puntosruta.Length-1; i++)
            {
               Gizmos.color=Color.red;
               Gizmos.DrawLine(puntosruta[i].position,puntosruta[i+1].position);
                
            }
            Gizmos.DrawLine(puntosruta[puntosruta.Length-1].position,puntosruta[0].position);

        }
        

    }

    

}
