using UnityEngine;
using System.Collections;

public interface Dialogue {
	void Enter();
	void Execute(int choice);
	void Exit();
}
