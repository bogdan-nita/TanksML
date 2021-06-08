using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TanksML
{
    public abstract class TankFactory : MonoBehaviour
    {
        public GameObject prefab;

        public Spawner spawner;

        public abstract void CreateInstance();
    }
}