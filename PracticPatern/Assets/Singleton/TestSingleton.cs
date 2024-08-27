using UnityEngine;

/// <summary>
/// ���� ���� ��������
/// </summary>
public class TestSingleton : MonoBehaviour
{
    /// <summary>
    /// ��� �������
    /// </summary>
    public static TestSingleton instance { get; private set; }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        UnityEngine.Debug.Log("DestroyClon: " + this.gameObject.name);
        Destroy(this.gameObject);
    }

    public void Debug()
    {
        UnityEngine.Debug.Log("TestSingleton");
    }

    public void StartDebug()
    {
        UnityEngine.Debug.Log("TestSingleton started");
    }
}
