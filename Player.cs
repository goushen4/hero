using UnityEngine;
using QFramework;

namespace Dream
{
	public partial class Player : ViewController
	{
		public float moveSpeed = 5f;//移动速度
		public float jumpForce = 10f;//跳跃力度

		public bool isGround;//判断是否在地面
		private Rigidbody2D rb;//人物身上的刚体
		void Start()
		{
			rb = GetComponent<Rigidbody2D>();
		}

        private void Update()
        {
			isGround = Physics2D.OverlapCircle(transform.position-new Vector3(0,0.369f,0), 0.2f, LayerMask.GetMask("Ground"));

			float horizontalInput = Input.GetAxis("Horizontal");
			Vector2 moveDirection = new Vector2(horizontalInput, 0);
			rb.velocity = new Vector2(moveDirection.x * moveSpeed, rb.velocity.y);

			if(isGround && Input.GetButtonDown("Jump"))
			{
				rb.velocity = new Vector2(rb.velocity.x, jumpForce);
			}
        }

        private void OnDrawGizmos()
        {
			Gizmos.DrawWireSphere(transform.position - new Vector3(0, 0.369f, 0), 0.2f);
        }
    }
}
