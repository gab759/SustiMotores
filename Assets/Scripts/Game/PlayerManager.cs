using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PlayerManager : MonoBehaviour
{
    public TextMeshProUGUI vidaText;
    public TextMeshProUGUI scoreText;

    public int lives = 3;
    public int score = 0;
    [SerializeField] private float distance = 0f;

    private void Update() {
        distance += Time.deltaTime;

        if(distance >= 1){
            score += (int) distance;
            distance = 0f;  
        }
        if (lives <= 0)
        {
            Debug.Log("cAMBIASTE DE ESCENA");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            lives--;
        }
    }
}
    