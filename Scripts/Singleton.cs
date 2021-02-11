using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �N���X�̃V���O���g��
/// MonoBehaviour�͔�Ή�
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class Singleton<T> where T : class, new()
{
    private static T instance = null;

    /// <summary>
    /// �B��̃C���X�^���X
    /// </summary>
    public static T Instance { get; private set; }

    /// <summary>
    /// �C���X�^���X�𐶐�����
    /// </summary>
    public static void CreateInstance()
    {
        Instance = new T();
    }

    /// <summary>
    /// �C���X�^���X��j������
    /// </summary>
    public void DestroyInstance()
    {
        Instance = null;
    }
}
