using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActions : MonoBehaviour {

		
	public void MANU_ACTION_GoToPage (string sceneName){

		Application.LoadLevel(sceneName);
	}
}
