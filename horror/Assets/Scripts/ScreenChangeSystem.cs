using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace greta
{
    public class ScreenChangeSystem : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButton(0)) 
            {
                SceneManager.LoadScene("game");
            }
        }

    }
}

