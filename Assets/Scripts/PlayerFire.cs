using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;

    public GameObject firePosition;
    public GameObject firePosition2;

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletFactory);
            GameObject bullet2 = Instantiate(bulletFactory);

            bullet.transform.position = firePosition.transform.position;
            bullet2.transform.position = firePosition2.transform.position;
        }


    }
}
