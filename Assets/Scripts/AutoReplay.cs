using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AutoReplay : MonoBehaviour
{
    float timer = 0;
    public Text info;

    // Use this for initialization
    void Start()
    {
        if (EnemyController.EnemyKilled == 3)
        {
            info.text = "Congratulations \n You Win!";
        }
    } 
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            Data.score = 0;
            EnemyController.EnemyKilled = 0;
            SceneManager.LoadScene("Gameplay");
        }
    }
}