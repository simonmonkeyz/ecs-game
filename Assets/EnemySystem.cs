using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class EnemySystem : ComponentSystem
{
  

    protected override void OnUpdate()
    {
        Debug.Log("is updated");

        Entities.ForEach((ref EnemyComponent enComponent) =>
        {


            enComponent.health += 1f * Time.DeltaTime;
            //Debug.Log(testComponent.Health);
        });

        //throw new System.NotImplementedException();
    }
}
