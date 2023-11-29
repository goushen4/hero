using UnityEngine;
using QFramework;

namespace goudan
{
	public partial class Player : ViewController
	{
		public float MovementSpeed = 5;
		void Start()
		{
			
			
		}

        private void Update()
        {
			var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
			var direction=new Vector2 (horizontal, vertical).normalized;

			SelfRigidbody2D.velocity= direction*MovementSpeed;
        }
    }
}
