using UnityEngine;

namespace Shiena.CircularTrail
{
	public class Actor : MonoBehaviour
	{
		void Update()
		{
			transform.Rotate(new Vector3(60 * Time.deltaTime, 90 * Time.deltaTime, 120 * Time.deltaTime));
		}
	}
}