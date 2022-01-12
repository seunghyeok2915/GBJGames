using UnityEngine;

public class ArrowMove : CONEntity
{
    // Start is called before the first frame update
    public Rigidbody2D rid;
     public override void Start()
    {
        rid = GetComponent<Rigidbody2D>(); // 화살 리지드바디
        rid.AddForce(new Vector2(1,1) * 10, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    public override void Update()
    {
        float angle = Mathf.Atan2(rid.velocity.y, rid.velocity.x);
        transform.localEulerAngles = new Vector3(0, 0, (angle * 180) / Mathf.PI);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            gameObject.SetActive(false);
        }
    }
}
