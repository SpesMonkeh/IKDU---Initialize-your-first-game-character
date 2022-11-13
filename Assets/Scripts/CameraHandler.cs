using System;
using Cinemachine;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CameraHandler : MonoBehaviour
{
	[Header("UI")]
	[SerializeField] RectTransform namePanel;
	[SerializeField] TMP_InputField inputField;
	[Space]
	[Header("Camera")]
	[SerializeField] CinemachineBrain cameraBrain;
	[SerializeField] CinemachineSmoothPath dollyPath;
	[SerializeField] CinemachineVirtualCamera virtualCam;

	readonly float waitTimeBeforeInvoke = 2f;
	
	void Start()
	{
		Invoke(nameof(BeginCameraMovement), waitTimeBeforeInvoke);
	}

	/// <summary>
	/// When called; the camera will begin moving along the designated dolly track.
	/// </summary>
	/// <seealso cref="CinemachineSmoothPath"/>
	void BeginCameraMovement()
	{
	}

	void LateUpdate()
	{
		
	}
}