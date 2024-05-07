using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;


// 1. �ϳ����� ����
// 2. ��𼭵� ���� ���� ����
public class ArticleManager : MonoBehaviour
{
    public static ArticleManager Instance { get; private set; }

    private List<Article> _articles = new List<Article>();

    public List<Article> Articles => _articles;
    
    private void Awake()
    {
        Instance = this;

        _articles.Add(new Article()
        {
            Name = "��ȫ��",
            Content = "�ȳ��ϼ���.",
            ArticleType = ArticleType.Normal,
            Like = 20,
            WriteTime = DateTime.Now
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
        });
    }

    private void Start()
    {
        
    }

    

        
      
    
}
