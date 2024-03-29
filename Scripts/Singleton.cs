using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// クラスのシングルトン
/// MonoBehaviourは非対応
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class Singleton<T> where T : class, new()
{
    private static object lookObj = new object();
    private static T instance = null;

    /// <summary>
    /// 唯一のインスタンス
    /// </summary>
    public static T Instance { get; private set; }

    /// <summary>
    /// インスタンスを生成する
    /// </summary>
    public static void CreateInstance()
    {
        lock (lookObj)
        {
            Instance = new T();
        }
    }

    /// <summary>
    /// インスタンスを破棄する
    /// </summary>
    public void DestroyInstance()
    {
        lock (lookObj)
        {
            Instance = null;
        }
    }
}
