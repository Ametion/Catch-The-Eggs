using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Components
{
    public class ScoreComponent : MonoBehaviour
    {
        [SerializeField] private Text scoreText;
        [SerializeField] private UnityEvent onDie;
        
        private int _score;

        public void ModifyScore(int scoreDelta)
        {
            _score += scoreDelta;
            scoreText.text = _score.ToString();
            
            if(_score <= 0) onDie?.Invoke();
        }
    }
}