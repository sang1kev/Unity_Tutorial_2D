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
    /// 보통 GameManager라는 Script를 만들고 그곳에 Awake를 작성 하여 메인 을 만듦
    /// 이후 다른 script에서는 Start를 이용
    /// </summary>
    void Awake()        // Start 보다 빠르게 작동, 시스템 주축을 세팅(핵심), Start는 sub
    {
        CreatePrefab();
        /*destPrefab = GameObject.Find(destName);
        Destroy(destPrefab, destroyTime);     // 매개 변수로 들어간 게임오브젝트 파괴*/
    }

    /// <summary>
    /// Prefab 캐릭터 생성 메서드
    /// </summary>
    public void CreatePrefab ()
    {
        GameObject obj = Instantiate(prefab, pos, rot); // game object를 생성하는 함수
        Transform objTf = obj.transform;
        obj.name = charName;
        int childNum = objTf.childCount;
        //Transform objChildLast = objTf.GetChild(childNum - 1);

        Debug.Log($"{charName}이 생성되었습니다.");
        Debug.Log($"캐릭터의 자식 오브젝트 수 : {childNum}");
        Debug.Log($"캐릭터의 첫 자식 오브젝트 : {objTf.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트 : {objTf.GetChild(childNum - 1).name}");

        //Debug.Log($"캐릭터의 마지막 자식 오브젝트의 자식의 이름 : {objChildLast.GetChild(0).name}");
    }
    /*void OnDestroy() // 파괴될 때 1번 실행, 파괴 X시 프로그램 종료시 실행
    {
        Debug.Log($"{destName}이 파괴되었습니다.");
    }*/
    
}
