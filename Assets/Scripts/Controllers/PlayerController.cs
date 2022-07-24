using UnityEngine;

[CreateAssetMenu(fileName = "PlayerController", menuName = "InputController/PlayerController")]
public class PlayerController : InputController {

	public override bool RetrieveJumpInput() {
		throw new System.NotImplementedException();
	}

	public override float RetrieveMoveInput() {
		throw new System.NotImplementedException();
	}
}

