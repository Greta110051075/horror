using UnityEngine;
using TMPro;
using System.Collections;

namespace greta
{
    public class DialogueSystem : MonoBehaviour
    {
        #region 資料區域
        [SerializeField, Header("對話間隔"), Range(0, 0.5f)]
        private float dialogueIntervalTime = 0.1f;

        private WaitForSeconds dialogueInterval => new WaitForSeconds(dialogueIntervalTime);

        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textName;
        private TextMeshProUGUI textContent;
        private GameObject goTriangle;
        #endregion

        #region 事件
        private void Awake()
        {
            groupDialogue = GameObject.Find("畫布對話系統").GetComponent<CanvasGroup>();
            textName = GameObject.Find("對話者名稱").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("對話內容").GetComponent<TextMeshProUGUI>();
            goTriangle = GameObject.Find("對話完成圖示");
            goTriangle.SetActive(false);

            StartCoroutine(FadeGroup());
        } 
        #endregion

        ///<summary>
        ///淡入淡出群組物件
        ///</summary>
        private IEnumerator FadeGroup() 
        {
            for (int i = 0; i < 10; i++) 
            {
                groupDialogue.alpha += 0.1f;
                yield return new WaitForSeconds(0.04f);
            }
        }
    }
}


