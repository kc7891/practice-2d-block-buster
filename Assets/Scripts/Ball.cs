using UnityEngine;
class Ball : MonoBehaviour
{
    // ボールの移動の速さを指定する変数
    public float speed = 5f;
    public float minSpeed = 5f;
    public float maxSpeed = 10f;

    Rigidbody myRigidbody;
    Transform myTransform;

    void Start()
    {
        // Rigidbodyにアクセスして変数に保持しておく
        myRigidbody = GetComponent<Rigidbody>();
        // 右斜め45度に進む
        myRigidbody.velocity = new Vector3(speed, speed, 0f);
        myTransform = transform;
    }

    void Update()
    {
        Vector3 velocity = myRigidbody.velocity;
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);
        myRigidbody.velocity = velocity.normalized * clampedSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.CompareTag("Player") ) {
            Vector3 playerPos = collision.transform.position;
            Vector3 ballPos = myTransform.position;
            Vector3 direction = (ballPos - playerPos).normalized;
            float speed = myRigidbody.velocity.magnitude;
            myRigidbody.velocity = direction * speed;
	    }
    }
}
