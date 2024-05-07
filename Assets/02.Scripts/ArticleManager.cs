using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

// 1. �ϳ����� ����
// 2. ��𼭵� ���� ���� ����
public class ArticleManager : MonoBehaviour
{
    // �Խñ� ����Ʈ
    private List<Article> _articles = new List<Article>();
    public List<Article> Articles => _articles;

    public static ArticleManager Instance { get; private set; }
    private void Awake()
    {
        Instance = this;

        /*_articles.Add(new Article()
        {
            Name = "��ȫ��",
            Content = "�ȳ��ϼ���.",
            ArticleType = ArticleType.Normal,
            Like =  20,
            WriteTime =  DateTime.Now
        }); 
        _articles.Add(new Article()
        {
            Name = "�ο���",
            Content = "����",
            ArticleType = ArticleType.Normal,
            Like = 7,
            WriteTime = DateTime.Now
        });
        _articles.Add(new Article()
        {
            Name = "�����",
            Content = "�ػ�:)",
            ArticleType = ArticleType.Normal,
            Like = 908,
            WriteTime = DateTime.Now

        });
        _articles.Add(new Article()
        {
            Name = "��¿�",
            Content = "�ȳ��ϼ�~",
            ArticleType = ArticleType.Normal,
            Like = 20,
            WriteTime = DateTime.Now
        });
        _articles.Add(new Article()
        {
            Name = "����ȯ",
            Content = "���� �����̴�.",
            ArticleType = ArticleType.Normal,
            Like = 320,
            WriteTime = DateTime.Now
        });
        _articles.Add(new Article()
        {
            Name = "�̼���",
            Content = "���� ¯�̴�.",
            ArticleType = ArticleType.Normal,
            Like = 30,
            WriteTime = DateTime.Now
        });
        _articles.Add(new Article()
        {
            Name = "96���������",
            Content = "���̷�氡�氡",
            ArticleType = ArticleType.Normal,
            Like = 20,
            WriteTime = DateTime.Now
        });*/

        // JSON�̶� �ڹٽ�ũ��Ʈ ��ü ǥ������� ���� ���� ���� ����ϴ�
        //         ������ �ؽ�Ʈ ����
        // C#�� ��ųʸ��� ǥ���ϴ� ����� ����ϴ�.
        // "Ű":"���" ������ �����͸� ��ü({})�� �迭([])�� �������� ǥ���Ѵ�.

        // ����Ƽ�� Ư���� ���� ���� ���
        // ����Ƽ���� �� �� �ִ� ���� ���� ��θ� ������ �ִ�.
        Debug.Log(Application.persistentDataPath);
        string path = Application.persistentDataPath;

        // 1. ��ü�� Json������ �ؽ����� ��ȯ�� ���� ���� 'data.txt'�� �����Ѵ�.
        // json�� �Ϲ� Ŭ������ ����ȭ�� �� ������ ����Ʈ �� ��ü�� ����ȭ�� ���Ѵ�.
        // �Ϲ� Ŭ������ ����Ʈ�� ���� �����.
        /*ArticleData articleData = new ArticleData(_articles);
        string jsonData = JsonUtility.ToJson(articleData);
        Debug.Log(jsonData);
        StreamWriter sw = File.CreateText($"{path}/data.txt");
        sw.Write(jsonData);
        sw.Close();*/

        // 2. �����͸� �ϵ��ڵ��� �ڵ带 �����.
        // 3. 'data.txt'�κ��� json�� �о�ͼ� ��ü���� �ʱ�ȭ�Ѵ�.
        string txt = File.ReadAllText($"{path}/data.txt");
        _articles = JsonUtility.FromJson<ArticleData>(txt).Data;
    }
}