using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Article 데이터를 보여주는 게임 오브젝트
public class UI_Article : MonoBehaviour
{
    public Text ArticleTypeTextUI;
    public Text NameTextUI; // 글쓴이
    public Text TitleTextUI; // 글 제목
    public Text ContentTextUI; // 글 내용
    public Text LikeTextUI; // 좋아요 개수
    public Text WrieTimeTextUI; // 글 쓴 날짜 / 시간
    public void Init(Article article)
    {
        NameTextUI.text = article.Name;
        TitleTextUI.text = article.Title;
        ContentTextUI.text = article.Content;
        LikeTextUI.text = $"{article.Like}";
        WrieTimeTextUI.text = $"{ article.WrieTime}";
    }

}
