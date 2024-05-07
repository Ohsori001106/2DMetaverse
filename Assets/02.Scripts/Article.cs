using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ArticleType
{
    Normal,
    Notice,
}
public class Article
{
    public ArticleType ArticleType;
    public string Name; // �۾���
    public string Title; // �� ����
    public string Content; // �� ����
    public int Like; // ���ƿ� ����
    public DateTime WriteTime; // �� �� ��¥ / �ð�
}
