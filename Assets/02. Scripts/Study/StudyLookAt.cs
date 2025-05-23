using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTF;
    private Transform turretBulletTF;
    private Transform turretMissleTF;

    public GameObject bulletPrefab;
    public Transform[] firePos;

    public float timer;
    public float coolTime = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetTF = GameObject.FindGameObjectWithTag("Player").transform;
        turretBulletTF = GameObject.Find("Turret_Bullet_Head").transform;
        turretMissleTF = GameObject.Find("Turret_Missle_Head").transform;
    }

    // Update is called once per frame
    void Update()
    {
        turretBulletTF.LookAt(targetTF);
        turretMissleTF.LookAt(targetTF);

        timer += Time.deltaTime;
        if (timer >= coolTime) 
        {
            for (int i = 0; i < firePos.Length; i++)
            {
                timer = 0;
                Instantiate(bulletPrefab, firePos[i].position, firePos[i].rotation);
            }
        }
    }
}