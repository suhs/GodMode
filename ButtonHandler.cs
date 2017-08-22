using UnityEngine.UI;
using System.Collections;

public class ButtonHandler : MonoBehaviour {
  public Button decisionButton;

  void Start()
  {
    Button btn = decisionButton.GetComponent<Button>();
    //btn.onClick.AddListener(TODO);
  }



}
