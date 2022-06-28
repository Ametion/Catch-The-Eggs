using UnityEngine;

namespace Components
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Basket : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        
        private Rigidbody2D _rigidbody;

        private void Awake() => _rigidbody = GetComponent<Rigidbody2D>();

        private void FixedUpdate() => _rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, 0);
    }
}