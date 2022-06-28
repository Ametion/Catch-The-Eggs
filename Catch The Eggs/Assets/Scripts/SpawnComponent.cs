using System.Collections;
using UnityEngine;

namespace Components
{
    public class SpawnComponent : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform position;
        [SerializeField] private Transform parent;
    
        [SerializeField] private bool eggSpawner;
        [SerializeField] private float spawnTime;

        private void Awake()
        {
            if (eggSpawner)
                StartCoroutine(EggSpawner());
        }
    
        public void SpawnInParent() => Instantiate(prefab, parent);

        private IEnumerator EggSpawner()
        {
            while (true)
            {
                yield return new WaitForSeconds(spawnTime);
                Instantiate(prefab, new Vector3(Random.Range(-8, 8), 5.5f, 0), Quaternion.identity);
            }
        }
    }
}