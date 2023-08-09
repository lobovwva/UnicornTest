using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject panelWin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // когда игрок подходит к финишу запускается панель выигрыша 
            panelWin.SetActive(true);
    }
}
