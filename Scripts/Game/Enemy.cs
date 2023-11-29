using UnityEngine;
using QFramework;

namespace goudan
{
	public partial class Enemy : ViewController
	{
		public float MovementSpeed = 2.0f;
		void Start()
		{
			// Code Here123123123123
		}

        private void Update()
        {
            var player=FindObjectOfType<Player>();

			var direction = (player.transform.position - transform.position).normalized;
			Debug.Log(direction);
			transform.Translate(direction * Time.deltaTime * MovementSpeed);
        }
    }
}
