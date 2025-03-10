using UnityEngine;

public class RigidBodyBooster : MonoBehaviour
{

    [SerializeField] private float _forceAmount = 100f;
    private Rigidbody _rigidbody;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * _forceAmount);
        }
    }
}
