using UnityEngine;
using System.Collections;

//싱글톤을 사용하는 스크립트 작성 시 이 클래스를 상속받아 사용하시면 됩니다.
public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour 
{

    private static T _instance;
    public static T instance
    {
        get
        {
            if (_instance == null)
            {
                try
                {
                    _instance = (T)FindObjectOfType<T>();
                }
                catch (System.Exception e)
                {
                    Debug.LogError(e.StackTrace);
                    return null;
                }
            }
            return _instance;
        }
    }
}