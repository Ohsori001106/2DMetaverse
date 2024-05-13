using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using MongoDB.Driver;
using static UnityEngine.ParticleSystem;

// Article 데이터를 보여주는 게임 오브젝트
public class UI_Article : MonoBehaviour
{
    public Image ProfileImageUI; // 프로필 이미지
    
    public TextMeshProUGUI NameTextUI; // 글쓴이
    
    public TextMeshProUGUI ContentTextUI; // 글 내용
    public TextMeshProUGUI LikeTextUI; // 좋아요 개수
    public TextMeshProUGUI WriteTimeTextUI; // 글 쓴 날짜 / 시간

    public UI_ArticleMenu MenuUI;

    private Article _article;
    public void Init(Article article)
    {
        NameTextUI.text = article.Name;
        
        ContentTextUI.text = article.Content;
        LikeTextUI.text = $"{article.Like}";
        WriteTimeTextUI.text = GetTimeString(article.WriteTime);
    }

    private string GetTimeString(DateTime dateTime)
    {
        TimeSpan time = DateTime.Now - dateTime;
        if (time.Minutes < 1)
            return "방금 전";
        else if (time.Hours < 1 && time.Days == 0)
            return $"{time.Minutes}분 전";
        else if (time.Days < 1)
            return $"{time.Hours}시간 전";
        else if (time.Days < 7)
            return $"{time.Days}일 전";
        else return $"{dateTime}";
    }

    public void OnClickMenuButton()
    {
        MenuUI.Show(_article);
    }

    public void OnClickLikeButton()
    {
        // 1. 데이터 조작은 항상 매니저에게 시킨다.
        ArticleManager.Instance.AddLike(_article);

        ArticleManager.Instance.FindAll();
        UI_ArticleList.Instance.Refresh();
    }
}
