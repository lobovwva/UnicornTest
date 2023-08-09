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
        // ������� ��������� ������ � �������� ���������
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (panelGO.activeSelf) //���� ������� ������ GameOver �� ������������� �������� loose 
        {
            speed = 0f;
            skeletonAnimation.AnimationName = "loose";
            skeletonAnimation.AnimationState.TimeScale = 0.5f;
        }

        if (panelWin.activeSelf) //���� ������� ������ ������ �� ������������� �������� idle
        {
            speed = 0f;
            skeletonAnimation.AnimationName = "idle";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // ��� ������������ � ������ ���������� ������ GameOver
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // ��������� ����
            panelGO.SetActive(true);
        }
    }

}
