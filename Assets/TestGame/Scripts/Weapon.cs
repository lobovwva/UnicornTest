using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform point;
    [SerializeField] private float startTime;
    [SerializeField] private GameObject muzzleEffect;
    [SerializeField] private GameObject panelGO;
    [SerializeField] private GameObject panelWin;

    private float time;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(time <= 0f)
        {
            if(Input.GetMouseButtonDown(0) && !panelGO.activeSelf && !panelWin.activeSelf) // ��� ������� ��� � ��� ������� ��� ������ �� �������(����� ����� ����� ������ ������� ��� ����� �� ��������������� �������) ��������������� �������
            {
                audioSource.Play();
                Instantiate(muzzleEffect, point.position, Quaternion.identity);
                Instantiate(bullet.transform, point.position, transform.rotation);
                time = startTime;
            }
        }
        else
        {
            time -=Time.deltaTime;
        }
    }
}
