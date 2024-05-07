using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MVC ��Ű��ó ����
// - Model (�����Ϳ� �� �����͸� �ٷ�� ����) -> Article
// - View  (UI, ����� �������̽�)            -> UI_Article, UI_ArticleList
// - Controller (������, Model <-> View ������) -> ArticleManager , ����: ����,����,����
// �� ��ҵ�(������, �ð���, ����)�� �������� ���������� ������ �� �ִ�.

public enum ArticleType
{
    Normal,
    Notice,
}

[Serializable]
public class Article
{
    public ArticleType ArticleType;
    public string Name; // �۾���
    public string Title; // �� ����
    public string Content; // �� ����
    public int Like; // ���ƿ� ����
    public DateTime WriteTime; // �� �� ��¥ / �ð�
}

[Serializable]
public class ArticleData
{
    public List<Article> Data;

    public ArticleData(List<Article> data)
    {
        Data = data;
    }
}
