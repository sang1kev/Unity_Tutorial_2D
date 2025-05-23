using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTF;
    private Transform turretTF;

    public GameObject bulletPrefab;
    public Transform[] firePos;

    public float timer;
    public float coolTime = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetTF = GameObject.FindGameObjectWithTag("Player").transform;
        turretTF = GameObject.Find("Turret_Head").transform;
    }

    // Update is called once per frame
    void Update()
    {
        turretTF.LookAt(targetTF);

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