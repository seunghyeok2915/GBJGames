using UnityEngine;

public class ArrowMove : CONEntity
{
    // Start is called before the first frame update
    Rigidbody2D rid;
     public override void Start()
    {
        rid = GetComponent<Rigidbody2D>(); // 화살 리지드바디
    }

    // Update is called once per frame
    public override void Update()
    {
        float angle = Mathf.Atan2(rid.velocity.y, rid.velocity.x);
        transform.localEulerAngles = new Vector3(0, 0, (angle * 180) / Mathf.PI);
    }
}
