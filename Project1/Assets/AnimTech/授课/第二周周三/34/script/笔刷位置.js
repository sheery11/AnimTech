#pragma strict
private var Value_X :float =  0.0f;
private var Value_Y :float =  0.0f;
private var Value_Z :float = 0.0f;
private var obj : GameObject;
function Start () {
	obj = GameObject.Find ("colorRing");
}

function OnGUI(){
//    GUILayout.Box("缩放强度");
//    Value_X = GUILayout.HorizontalSlider(Value_X,-10.0f,10.0f,GUILayout.Width(200));
////    GUILayout.Box("移动y轴");
////    Value_Y = GUILayout.HorizontalSlider(Value_Y,-10.0f,10.0f,GUILayout.Width(200));
//
//    obj.transform.position = Vector3(Value_X,Value_Y,Value_Z);
//    GUILayout.Label("立方体当前位置:"+obj.transform.position);


}
function Update () {
	
}
