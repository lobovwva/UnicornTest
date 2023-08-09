using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public void Restart() // перезапуск сцены при клике, висит на панелях 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
