using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public StageData stageData;

    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        /*
        Vector3 dir = Vector3.right * h + Vector3.up * v;

        // vector3.up, vector3.down, vector3.left
        transform.Translate(dir * speed * Time.deltaTime);
        */

        Vector3 dir = new Vector3(h, v, 0);

        transform.position += dir * speed * Time.deltaTime;
    }


    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.limitMin.x, stageData.limitMax.x), Mathf.Clamp(transform.position.y, stageData.limitMin.y, stageData.limitMax.y));
    }
}
