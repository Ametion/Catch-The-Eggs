using System;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnter : MonoBehaviour
{
    [SerializeField] private string tag;
    [SerializeField] private EnterEvent _event;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag(tag))
        {
            _event?.Invoke(other.gameObject);
        }
    }
}

[Serializable]
public class EnterEvent : UnityEvent<GameObject> { }
