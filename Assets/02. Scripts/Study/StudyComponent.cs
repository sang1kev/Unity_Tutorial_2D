using Unity.VisualScripting;
using UnityEngine;

// ����������       Ŭ������  : ����Ƽ�� ����� ����ִ� ��
public class StudyComponent : MonoBehaviour
{
    // ����������  Ÿ��  ������;
    public GameObject obj;

    public Mesh mesh;
    public Material material;
    //public Transform objTf;
    //public string changeName;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube); //ť�� ���� �Լ�
        CreateCube();
        CreateCube("hihi");

        //obj = GameObject.Find("Main Camera");
        /* obj = GameObject.FindGameObjectWithTag("Player"); //find ��� �� private ��� ����
        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        obj.GetComponent<MeshRenderer>().enabled = false;  
        obj.SetActive(false);

        Debug.Log($"<color=#FF0000>Game object name : {obj.name}</color>");  //�� �ڵ�
        Debug.Log($"Game object tag : {obj.tag}");
        Debug.Log($"Game object position : {obj.transform.position}");
        Debug.Log($"Game object rotation : {obj.transform.rotation}");
        Debug.Log($"Game object lacalscale : {obj.transform.localScale}");

        // ������Ʈ, Meshfilter�� renderer�� ���� mesh�� material�� ���
        Debug.Log($"Mesh data : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Material data : {obj.GetComponent<MeshRenderer>().material}");
        //obj.name = changeName;*/
    }   //�߰�ȣ ���� = ������ �Լ��� ���� �ֱ�, �Լ��� �ڵ带 �ۼ��ϴ� ����

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
