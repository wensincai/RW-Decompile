using System;

namespace Verse.AI
{
	public class ThinkNode_ChancePerHour_Constant : ThinkNode_ChancePerHour
	{
		private float mtbHours = 1f;

		public override ThinkNode DeepCopy()
		{
			ThinkNode_ChancePerHour_Constant thinkNode_ChancePerHour_Constant = (ThinkNode_ChancePerHour_Constant)base.DeepCopy();
			thinkNode_ChancePerHour_Constant.mtbHours = this.mtbHours;
			return thinkNode_ChancePerHour_Constant;
		}

		protected override float MtbHours(Pawn Pawn)
		{
			return this.mtbHours;
		}
	}
}