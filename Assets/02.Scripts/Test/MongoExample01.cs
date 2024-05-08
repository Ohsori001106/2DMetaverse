using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MongoExample01 : MonoBehaviour
{
    
    void Start()
    {
        // ���� �����ͺ��̽��� ����
        // ���� ���ڿ�: �����ͺ��̽� ������ ���� ������ ����ִ� ���ڿ�
        string connectionString = "mongodb+srv://qwer7495:qwer7431@cluster0.tbmc7hw.mongodb.net/";
        // - ��������: mongodb+srv
        // - ���̵�: qwer7495
        // - ��й�ȣ:qwer7431
        // - �ּ�: cluster0.tbmc7hw.mongodb.net

        // 1. ����
        MongoClient mongoClient = new MongoClient(connectionString);

        // 2. �����ͺ��̽��� ��������?
        List<BsonDocument> dbList = mongoClient.ListDatabases().ToList();
        foreach(BsonDocument db in dbList)
        {
            Debug.Log(db["name"]);
        }

        // 3. Ư�� �����ͺ��̽��� ����
        IMongoDatabase sampleDB = mongoClient.GetDatabase("sample_mflix");

        // 4. �ݷ��ǵ� �̸� Ȯ��
        List<string> collectionNames = sampleDB.ListCollectionNames().ToList();
        foreach(string name in collectionNames)
        {
            Debug.Log(name);
        }

        // 5. �ݷ��� ����
        /*IMongoCollection<BsonDocument>*/var movieCollection = sampleDB.GetCollection<BsonDocument>("movies");
        long count = movieCollection.CountDocuments(new BsonDocument());
        Debug.Log($"��ȭ ����: {count}");

        // 6. ��ť��Ʈ �ϳ��� �б�
         var firstDoc = movieCollection.Find(new BsonDocument()).FirstOrDefault();
        Debug.Log(firstDoc["plit"]);

    }




    void Update()
    {
        
    }
}
