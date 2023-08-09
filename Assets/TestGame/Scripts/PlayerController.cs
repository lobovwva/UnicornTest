using Spine.Unity;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject panelGO;
    [SerializeField] private GameObject panelWin;

    private SkeletonAnimation skeletonAnimation;

    private void Start()
    {
        skeletonAnimation = GetComponentInChildren<SkeletonAnimation>();
    }

    private void Update()
    {
        // Двигаем персонажа вправо с заданной скоростью
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (panelGO.activeSelf) //если активна панель GameOver то проигрывается анимация loose 
        {
            speed = 0f;
            skeletonAnimation.AnimationName = "loose";
            skeletonAnimation.AnimationState.TimeScale = 0.5f;
        }

        if (panelWin.activeSelf) //если активна панель финиша то проигрывается анимация idle
        {
            speed = 0f;
            skeletonAnimation.AnimationName = "idle";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // при столкновении с врагом появляется панель GameOver
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Проиграть игру
            panelGO.SetActive(true);
        }
    }

}
