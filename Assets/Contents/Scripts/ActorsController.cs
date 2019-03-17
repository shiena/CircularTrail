using System.Linq;
using UnityEngine;

namespace Shiena.CircularTrail
{
	public class ActorsController : MonoBehaviour
	{
		[SerializeField] private GameObject actor;

		[SerializeField] private GameObject actorsParent;

		[SerializeField] private int actorsNum = 10;

		[SerializeField] private float angleRangeMax = 180f;
		[SerializeField] private float angleRangeMin = -180f;

		[SerializeField] private float scaleRangeMax = 1.4f;
		[SerializeField] private float scaleRangeMin = 0.1f;

		void Start()
		{
			Enumerable.Range(0, actorsNum)
				.ToList()
				.ForEach(obj =>
				{
					var temp = Instantiate(actor, actorsParent.transform, true);
					SetActorsParameter(temp);
				});
		}

		private void SetActorsParameter(GameObject _actor)
		{
			_actor.transform.localScale = Random.Range(scaleRangeMin, scaleRangeMax) * Vector3.one;
			_actor.transform.localRotation = Quaternion.Euler(
				Random.Range(angleRangeMin, angleRangeMax),
				Random.Range(angleRangeMin, angleRangeMax),
				Random.Range(angleRangeMin, angleRangeMax)
			);
		}
	}
}