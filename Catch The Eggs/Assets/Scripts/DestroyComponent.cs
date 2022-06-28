using System;
using UnityEngine;

namespace Components
{
    public class DestroyComponent : MonoBehaviour
    {
        [SerializeField] private bool destoyByTimer;
        [SerializeField] private float destroyTime;

        private void Awake()
        {
            if (destoyByTimer) Destroy(gameObject, destroyTime);
        }

        public void DestroySelf() => Destroy(gameObject);

        public void DestroyTarget(GameObject target) => Destroy(target);
    }
}