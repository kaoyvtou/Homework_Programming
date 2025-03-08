using UnityEngine;
using UnityEngine.UIElements;

public class PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);
        }
        
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject bullet2 = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet2.transform.SetParent(bulletTrash);
        }
    }

}