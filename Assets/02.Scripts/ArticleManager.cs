using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Unity.Mathematics;
using UnityEngine;
using static UnityEngine.ParticleSystem;

// 1. 하나만을 보장
// 2. 어디서든 쉽게 접근 가능
public class ArticleManager : MonoBehaviour
{
    // 게시글 리스트
    private List<Article> _articles = new List<Article>();
    public List<Article> Articles => _articles;

    public UI_ArticleList UI_ArticleList;
    public static ArticleManager Instance { get; private set; }
    private void Awake()
    {
        Instance = this;

        

        // 몽고 DB로부터 article 조회
        string connectionString = "mongodb+srv://qwer7495:qwer7431@cluster0.tbmc7hw.mongodb.net/";
        // 1. 몽고DB 연결
        MongoClient mongoClient = new MongoClient(connectionString);
        // 2. 특정 데이터베이스 연결
        IMongoDatabase sampleDB = mongoClient.GetDatabase("metaverse");
        // 3. 특정 콜렉션 연결
        var article = sampleDB.GetCollection<BsonDocument>("articles");

        // 4. 모든 문서 읽어오기
        List<BsonDocument> datas = article.Find(new BsonDocument()).ToList();



        // 5. 읽어온 문서 만큼 New Article()해서 데이터 채우고
        _articles.Clear();

        foreach (var data in datas)
        {
            
            Article art = new Article();
            art.Name = data["Name"].ToString();
            art.Content = data["Content"].ToString();
            art.Like = (int)data["Like"];
            art.WriteTime = DateTime.Parse(data["WriteTime"].AsString);
            
            art.ArticleType = (ArticleType)(int)data["ArticleType"];
            //    _articles에 넣기+
            
            _articles.Add(art);

            
        }
        
        


    }

    public void OnClikNotice()
    {
        UI_ArticleList.Refresh();
        _articles.Clear();
        // 몽고 DB로부터 article 조회
        string connectionString = "mongodb+srv://qwer7495:qwer7431@cluster0.tbmc7hw.mongodb.net/";
        // 1. 몽고DB 연결
        MongoClient mongoClient = new MongoClient(connectionString);
        // 2. 특정 데이터베이스 연결
        IMongoDatabase sampleDB = mongoClient.GetDatabase("metaverse");
        // 3. 특정 콜렉션 연결
        var article = sampleDB.GetCollection<BsonDocument>("articles");

        // 4. 모든 문서 읽어오기
        var filter2 = Builders<BsonDocument>.Filter.Eq("ArticleType", 1);

        List<BsonDocument> datas = article.Find(filter2).ToList();


        foreach (var data in datas)
        {
            Article art = new Article();
            art.Name = data["Name"].ToString();
            art.Content = data["Content"].ToString();
            art.Like = (int)data["Like"];
            art.WriteTime = DateTime.Parse(data["WriteTime"].AsString);

            art.ArticleType = (ArticleType)(int)data["ArticleType"];


                _articles.Add(art);
            
           


        }
    }

    public void OnClikAllView()
    {
        UI_ArticleList.Refresh();
        _articles.Clear();
        // 몽고 DB로부터 article 조회
        string connectionString = "mongodb+srv://qwer7495:qwer7431@cluster0.tbmc7hw.mongodb.net/";
        // 1. 몽고DB 연결
        MongoClient mongoClient = new MongoClient(connectionString);
        // 2. 특정 데이터베이스 연결
        IMongoDatabase sampleDB = mongoClient.GetDatabase("metaverse");
        // 3. 특정 콜렉션 연결
        var article = sampleDB.GetCollection<BsonDocument>("articles");

        // 4. 모든 문서 읽어오기
        List<BsonDocument> datas = article.Find(new BsonDocument()).ToList();



        // 5. 읽어온 문서 만큼 New Article()해서 데이터 채우고
        

        foreach (var data in datas)
        {

            Article art = new Article();
            art.Name = data["Name"].ToString();
            art.Content = data["Content"].ToString();
            art.Like = (int)data["Like"];
            art.WriteTime = DateTime.Parse(data["WriteTime"].AsString);

            art.ArticleType = (ArticleType)(int)data["ArticleType"];
            //    _articles에 넣기+

            _articles.Add(art);


        }
    }
}

