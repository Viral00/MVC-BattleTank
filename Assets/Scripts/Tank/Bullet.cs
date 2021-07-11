using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
    }

    private Rigidbody rb;
    [SerializeField] private float bulletforce = 10f;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.AddForce(transform.forward * bulletforce, ForceMode.Impulse);
        //rb.AddForce(transform.up * 5f, ForceMode.Impulse);
    }

}
