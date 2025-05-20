using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 10f;     //public 유니티 에디터 상에서 보이도록 함, private는 변수가 보이지 않음

    void Start() //세팅
    {
        //현재  위치  = 현재위치 + (0,0,1)
        /*Debug.Log($"현재 z축의 값은 {this.transform.position.z}");
        this.transform.position += Vector3.forward;
        Debug.Log($"현재 z축의 값은 {this.transform.position.z}");*/
    }

    // Update is called once per frame
    void Update() //동작
    {
        //this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;    //일반적으로 update에서 사용되는 움직임 코드
        //this.GetComponent<Rigidbody>().linearVelocity = 
        //Time.deltatime 프레임 보정할 때 사용 deltatime은 프레임과 프레임 사이의 시간
        //Time.deltatime으로 서로 다른 프레임에서 같은 속도를 냄
        //fps 100에서 1초에 100이 움직임 fps 30에선 30을 움직임
        //따라서 모든 fps에서 같은 속도를 내기 위해 deltatime을 사용 
        if (Input.GetKey(KeyCode.LeftShift))    //달리기
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
        else if (Input.GetKey(KeyCode.LeftAlt))
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
        }
    }
}
