using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 10f;     //public ����Ƽ ������ �󿡼� ���̵��� ��, private�� ������ ������ ����

    void Start() //����
    {
        //����  ��ġ  = ������ġ + (0,0,1)
        /*Debug.Log($"���� z���� ���� {this.transform.position.z}");
        this.transform.position += Vector3.forward;
        Debug.Log($"���� z���� ���� {this.transform.position.z}");*/
    }

    // Update is called once per frame
    void Update() //����
    {
        //this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;    //�Ϲ������� update���� ���Ǵ� ������ �ڵ�
        //this.GetComponent<Rigidbody>().linearVelocity = 
        //Time.deltatime ������ ������ �� ��� deltatime�� �����Ӱ� ������ ������ �ð�
        //Time.deltatime���� ���� �ٸ� �����ӿ��� ���� �ӵ��� ��
        //fps 100���� 1�ʿ� 100�� ������ fps 30���� 30�� ������
        //���� ��� fps���� ���� �ӵ��� ���� ���� deltatime�� ��� 
        // �Է°��� ���� ��ӵ� �ý���
        // �̵�, ����, interaction �� wasd, space, mouse click
        /*if (Input.GetKey(KeyCode.LeftShift))    //�޸���
        {
            moveSpeed = moveSpeed * 4;
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
            }
            moveSpeed = moveSpeed / 4;
        }
        else if (Input.GetKey(KeyCode.C))
        {
            moveSpeed = moveSpeed / 4;
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
            }
            moveSpeed = moveSpeed * 4;
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
            }
        }*/
        // Input System (Old - Legacy)
        //�ε巴��
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //�������� ��
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");


        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normalDir = dir.normalized;     //�ӵ� ����ȭ �밢�� �ӵ��� ����
        
        Debug.Log($"���� �Է� : {normalDir}");

        transform.position += normalDir * moveSpeed * Time.deltaTime;
        transform.LookAt(transform.position + normalDir); 
    }
}
