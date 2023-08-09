using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject panelWin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // ����� ����� �������� � ������ ����������� ������ �������� 
            panelWin.SetActive(true);
    }
}
