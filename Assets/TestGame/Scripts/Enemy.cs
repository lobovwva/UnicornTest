using Spine.Unity;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private float speed;

    private SkeletonAnimation skeletonAnimation;

    private void Start()
    {
        skeletonAnimation = GetComponentInChildren<SkeletonAnimation>(); // ����� �������� ������ � ������� ��������� ��������� ��������
    }

    private void Update()
    {
        // ������� ����� ������ � �������� ���������
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (health <= 0) 
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // ��� ������������ � ������� ������������� �������� win
        {
            speed = 0f;
            skeletonAnimation.AnimationName = "win";
            skeletonAnimation.AnimationState.TimeScale = 0.5f;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
