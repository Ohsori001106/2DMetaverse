using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Article �����͸� �����ִ� ���� ������Ʈ
public class UI_Article : MonoBehaviour
{
    public Text ArticleTypeTextUI;
    public Text NameTextUI; // �۾���
    public Text TitleTextUI; // �� ����
    public Text ContentTextUI; // �� ����
    public Text LikeTextUI; // ���ƿ� ����
    public Text WrieTimeTextUI; // �� �� ��¥ / �ð�
    public void Init(Article article)
    {
        NameTextUI.text = article.Name;
        TitleTextUI.text = article.Title;
        ContentTextUI.text = article.Content;
        LikeTextUI.text = $"{article.Like}";
        WrieTimeTextUI.text = $"{ article.WrieTime}";
    }

}
