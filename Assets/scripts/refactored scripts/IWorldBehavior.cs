using UnityEngine;
using System.Collections;

public interface IWorldBehavior{

	void React(ThrowableType[] type);
	void Initialize();
}
