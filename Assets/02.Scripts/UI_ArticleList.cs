using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class UI_ArticleList : MonoBehaviour
{
    public List<UI_Article> UIArticles;
    public GameObject EmptyObject;

    private void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        // 1. Article�Ŵ����κ��� Article�� �����´�.
        List<Article> articles = ArticleManager.Instance.Articles;

        // �Խñ� ������ 0���� ���� 'ù ���� �ۼ��غ�����' �����ֱ�
        EmptyObject.gameObject.SetActive(articles.Count == 0);

        // 2. ��� UI_Article�� ����.
        foreach (UI_Article uiArticle in UIArticles)
        {
            uiArticle.gameObject.SetActive(false);
        }
        // 3. ������ Article ������ŭ UI_Article�� Ų��.
        for (int i = 0; i < articles.Count &&  i < articles.Count; i++)
        {
            UIArticles[i].gameObject.SetActive(true);
            // 4. �� UI_Article�� ������ Article�� �ʱ�ȭ(Init)�Ѵ�
            UIArticles[i].Init(articles[i]);
        }

        
    }
}
