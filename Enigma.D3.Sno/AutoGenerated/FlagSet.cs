using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class FlagSet : SerializeMemoryObject
	{
		// 2.0.6.24641
		public const int SizeOf = 0x20; // 32
		
		public FlagLookup[] x10_FlagLookups { get { return Deserialize<FlagLookup>(x18_SerializeData); } }
		public SerializeData x18_SerializeData { get { return Field<SerializeData>(0x18); } }
		
		[CompilerGenerated]
		public partial class FlagLookup : SerializeMemoryObject
		{
			// 2.0.6.24641
			public const int SizeOf = 0x184; // 388
			
			public int x000 { get { return Field<int>(0x000); } }
			public string x004_Text { get { return Field(0x004, 128); } }
			public string x084_Text { get { return Field(0x084, 256); } }
		}
	}
}