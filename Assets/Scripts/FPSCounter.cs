using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    [SerializeField] private float hudRefreshRate = 1f;

    public TextMeshProUGUI myText;

    private float _timer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.unscaledTime > _timer)
        {
            int fps = (int) (1f / Time.unscaledDeltaTime);
            
            _timer = Time.unscaledTime + hudRefreshRate;
            myText.text = "FPS: " + fps;
        }
    }
}
