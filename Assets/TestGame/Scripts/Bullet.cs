using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float distance;
    [SerializeField] private int damage;
    [SerializeField] private GameObject destroyEffect;
    [SerializeField] private LayerMask layerMask;

    void Update()
    {
        RaycastHit2D other = Physics2D.Raycast(transform.position, transform.up, distance, layerMask);
        if (other.collider != null)
        {
            if (other.collider.CompareTag("Enemy"))
            {
                other.collider.GetComponent<Enemy>().TakeDamage(damage);
                DestroyBullet();
            }
        }

        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestroyBullet()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
