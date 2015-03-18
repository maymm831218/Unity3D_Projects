using UnityEngine;
using System.Collections;

public class CrazyCube : MonoBehaviour {
	
	int translateSpeed = 10;
	int rotateSpeed = 500;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(Vector3.forward * Time.deltaTime * (-translateSpeed));
		}
		
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.forward * Time.deltaTime * translateSpeed);
		}
		
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(Vector3.up * Time.deltaTime * (-rotateSpeed));
		}
		
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
		}
	}
	
	void OnGUI()
	{
		GUI.backgroundColor = Color.red;
		
		if(GUI.Button(new Rect(10,10,70,30), "向左旋转"))
		{
			//向左旋转模型
			transform.Rotate(Vector3.up * Time.deltaTime * (-rotateSpeed));
		}
		
		if(GUI.Button(new Rect(90,10,70,30), "向前移动"))
		{
			//向前移动模型
			transform.Translate(Vector3.forward * Time.deltaTime * translateSpeed);
		}
		
		if(GUI.Button(new Rect(170,10,70,30), "向右移动"))
		{
			//向右移动模型
			transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
		}
		
		if(GUI.Button(new Rect(90,50,70,30), "向后移动"))
		{
			//向后移动模型
			transform.Translate(Vector3.forward * Time.deltaTime * (-translateSpeed));
		}
		
		//显示模型位置
		GUI.Label(new Rect(250,10,200,30), "模型位置:" + transform.position);
		GUI.Label(new Rect(250,50,200,30), "模型旋转:" + transform.rotation);
	}
}
