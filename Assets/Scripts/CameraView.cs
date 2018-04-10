using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraView : MonoBehaviour {
	[SerializeField]
	Camera cam1;
	[SerializeField]
	Camera cam2;
	[SerializeField]
	Camera cam3;



void Start() {
	cam1.enabled = true;
	cam2.enabled = false;
	cam3.enabled = false;

}

void Update() {

			if (Input.GetKeyDown(KeyCode.V) && (cam1.enabled == true || cam3.enabled == true)) {
		cam1.enabled = false;
		cam2.enabled = true;
		cam3.enabled = false;	
		}
			else if (Input.GetKeyDown(KeyCode.B) && (cam2.enabled == true || cam1.enabled == true)) {
		cam1.enabled = false;
		cam2.enabled = false;
		cam3.enabled = true;
		}
			else if (Input.GetKeyDown(KeyCode.C) && (cam2.enabled == true || cam3.enabled == true)) {
		cam1.enabled = true;
		cam2.enabled = false;
		cam3.enabled = false;			
		};
}
}

/*




public class ClickExample : MonoBehaviour
{
public Button yourButton;

void Start()
{
	Button btn = yourButton.GetComponent<Button>();
	btn.onClick.AddListener(TaskOnClick);
}

void TaskOnClick()
{
	Debug.Log("You have clicked the button!");
}
}
*/


