using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance => _instance;
    [SerializeField] private GameObject inforPanel;
    [SerializeField] private TextMeshProUGUI txtInformation;
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void ShowInfoPanel(GameObject go, Vector3 position)
    {
        transform.position = position;
        txtInformation.text = go.name;
        inforPanel.GetComponent<CanvasGroup>().alpha = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
