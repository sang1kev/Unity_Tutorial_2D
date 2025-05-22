using Unity.VisualScripting;
using UnityEngine;

// 접근제한자       클래스명  : 유니티의 기능이 들어있는 곳
public class StudyComponent : MonoBehaviour
{
    // 접근제한자  타입  변수명;
    public GameObject obj;

    public Mesh mesh;
    public Material material;
    //public Transform objTf;
    //public string changeName;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube); //큐브 생성 함수
        CreateCube();
        CreateCube("hihi");

        //obj = GameObject.Find("Main Camera");
        /* obj = GameObject.FindGameObjectWithTag("Player"); //find 사용 시 private 사용 권장
        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        obj.GetComponent<MeshRenderer>().enabled = false;  
        obj.SetActive(false);

        Debug.Log($"<color=#FF0000>Game object name : {obj.name}</color>");  //색 코드
        Debug.Log($"Game object tag : {obj.tag}");
        Debug.Log($"Game object position : {obj.transform.position}");
        Debug.Log($"Game object rotation : {obj.transform.rotation}");
        Debug.Log($"Game object lacalscale : {obj.transform.localScale}");

        // 컴포넌트, Meshfilter와 renderer에 접근 mesh와 material을 출력
        Debug.Log($"Mesh data : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Material data : {obj.GetComponent<MeshRenderer>().material}");
        //obj.name = changeName;*/
    }   //중괄호 사이 = 스코프 함수의 생명 주기, 함수의 코드를 작성하는 범위

    public void CreateCube(string name = "Cube")
    {
        obj = new GameObject(name);
        obj.AddComponent<MeshFilter>();
        obj.AddComponent<MeshRenderer>();
        obj.AddComponent<BoxCollider>();

        obj.GetComponent<MeshFilter>().mesh = mesh;
        obj.GetComponent<MeshRenderer>().material = material;
    }
}
