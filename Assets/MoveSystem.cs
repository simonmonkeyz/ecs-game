using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class MoveSystem : ComponentSystem
{
    protected override void OnUpdate()
    {

        Entities.ForEach((ref Translation trans) =>
        {
            Debug.Log("position is updated");
            trans.Value.y += 1f * Time.DeltaTime;
            
        });
    }
}
