using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshSpawner : Spawner
{
    public int maxNumberOfTries = 30;
    public float radius = 10.0f;

    [Button]
    public override Vector3 GetSpawnLocation()
    {
        Vector3 point;
        if (RandomPoint(transform.position, radius, out point))
        {
            Debug.DrawRay(point, Vector3.up, Color.green, 1.0f);
            print(point);
        }
        return point;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    bool RandomPoint(Vector3 center, float radius, out Vector3 result)
    {
        for (int i = 0; i < maxNumberOfTries; i++)
        {
            Vector3 randomPoint = center + Random.insideUnitSphere * radius;
            NavMeshHit hit;
            if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas))
            {
                result = hit.position;
                return true;
            }
        }
        result = Vector3.zero;
        return false;
    }
}
