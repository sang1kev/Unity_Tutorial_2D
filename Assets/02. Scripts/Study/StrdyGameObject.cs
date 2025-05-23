using UnityEngine;

public class StrdyGameObject : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 pos;
    public Quaternion rot;
    public string charName;
    // private GameObject destPrefab;
    // public float destroyTime = 2f;
    // public string destName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /// <summary>
    /// ���� GameManager��� Script�� ����� �װ��� Awake�� �ۼ� �Ͽ� ���� �� ����
    /// ���� �ٸ� script������ Start�� �̿�
    /// </summary>
    void Awake()        // Start ���� ������ �۵�, �ý��� ������ ����(�ٽ�), Start�� sub
    {
        CreatePrefab();
        /*destPrefab = GameObject.Find(destName);
        Destroy(destPrefab, destroyTime);     // �Ű� ������ �� ���ӿ�����Ʈ �ı�*/
    }

    /// <summary>
    /// Prefab ĳ���� ���� �޼���
    /// </summary>
    public void CreatePrefab ()
    {
        GameObject obj = Instantiate(prefab, pos, rot); // game object�� �����ϴ� �Լ�
        Transform objTf = obj.transform;
        obj.name = charName;
        int childNum = objTf.childCount;
        //Transform objChildLast = objTf.GetChild(childNum - 1);

        Debug.Log($"{charName}�� �����Ǿ����ϴ�.");
        Debug.Log($"ĳ������ �ڽ� ������Ʈ �� : {childNum}");
        Debug.Log($"ĳ������ ù �ڽ� ������Ʈ : {objTf.GetChild(0).name}");
        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ : {objTf.GetChild(childNum - 1).name}");

        //Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �ڽ��� �̸� : {objChildLast.GetChild(0).name}");
    }
    /*void OnDestroy() // �ı��� �� 1�� ����, �ı� X�� ���α׷� ����� ����
    {
        Debug.Log($"{destName}�� �ı��Ǿ����ϴ�.");
    }*/
    
}
