using UnityEngine;

public class space : MonoBehaviour
{
    public Rigidbody R;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        R = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        R.AddForce(Vector3.up);
    }
}
