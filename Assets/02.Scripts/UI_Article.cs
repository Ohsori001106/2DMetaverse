using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Article �����͸� �����ִ� ���� ������Ʈ
public class UI_Article : MonoBehaviour
{
    public Image ProfileImageUI; // ������ �̹���
    
    public TextMeshProUGUI NameTextUI; // �۾���
    
    public TextMeshProUGUI ContentTextUI; // �� ����
    public TextMeshProUGUI LikeTextUI; // ���ƿ� ����
    public TextMeshProUGUI WriteTimeTextUI; // �� �� ��¥ / �ð�
    public void Init(Article article)
    {
        NameTextUI.text = article.Name;
        
        ContentTextUI.text = article.Content;
        LikeTextUI.text = $"{article.Like}";
        WriteTimeTextUI.text = $"{ article.WriteTime}";
    }

}
