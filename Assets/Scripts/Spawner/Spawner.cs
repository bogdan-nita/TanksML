using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    public abstract Vector3 GetSpawnLocation();
}
