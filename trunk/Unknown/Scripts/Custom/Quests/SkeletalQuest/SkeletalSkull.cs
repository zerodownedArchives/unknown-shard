using System;
using Server;

namespace Server.Items
{
	[FlipableAttribute( 0x1451, 0x1456 )]
    public class SkeletalSkull : BaseLevelArmor
	{
		public override int BasePhysicalResistance{ get{ return 3; } }
		public override int BaseFireResistance{ get{ return 3; } }
		public override int BaseColdResistance{ get{ return 4; } }
		public override int BasePoisonResistance{ get{ return 2; } }
		public override int BaseEnergyResistance{ get{ return 4; } }

		public override int InitMinHits{ get{ return 125; } }
		public override int InitMaxHits{ get{ return 130; } }

		public override int AosStrReq{ get{ return 20; } }
		public override int OldStrReq{ get{ return 40; } }

		public override int ArmorBase{ get{ return 30; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Bone; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }


		[Constructable]
		public SkeletalSkull() : base( 0x1451 )
		{
			Name = "Skeletal Skull";
			Hue = 1950;
			Weight = 3.0;
		}

		public SkeletalSkull( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );

			if ( Weight == 1.0 )
				Weight = 3.0;
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}