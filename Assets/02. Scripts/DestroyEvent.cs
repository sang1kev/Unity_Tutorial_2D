using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, destTime);
    }
    void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}이 파괴되었습니다.");
    }

}
