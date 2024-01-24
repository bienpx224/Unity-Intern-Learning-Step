using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;
    [Header("List Color")] 
    [SerializeField] public Color colorButtonDefault;
    [SerializeField] public Color colorButton1;
    [SerializeField] public Color colorButton2;
    [Header("Player")]
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private TextMeshProUGUI bulletCount;
    private float bulletSpeed = 10;
    private int bulletCountIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (sprite == null)
        {
            sprite = GetComponent<SpriteRenderer>();
        }
    }
    private void Update()
    {
        RotateFollowMouse();
        Shooting();
    }

    public void ChangeColor(Color color)
    {
        sprite.color = color;
        StopAllCoroutines();
        StartCoroutine(IEReturnDefaultColor());
    }

    private IEnumerator IEReturnDefaultColor()
    {
        yield return new WaitForSeconds(2f);
        ChangeColor(colorButtonDefault);
    }
    void RotateFollowMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePosition - transform.position;
        direction.z = 0;

        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction.normalized);
    }
    void Shooting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
            bulletCountIndex = bulletCountIndex + 1;
            bulletCount.SetText(bulletCountIndex.ToString());
        }
    }
}
