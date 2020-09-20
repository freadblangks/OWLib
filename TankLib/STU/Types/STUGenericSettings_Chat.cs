// Generated by TankLibHelper

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0x30E8CEFC, "STUGenericSettings_Chat")]
    public class STUGenericSettings_Chat : STUGenericSettings_Base
    {
        [STUField(0xB54004FA, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUChatChannelDefinition[] m_chatChannels;
        
        [STUField(0x75D955D6, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUChatCommand[] m_chatCommands;
        
        [STUField(0x8C4E0BA1)]
        public float m_8C4E0BA1 = 10f;
        
        [STUField(0x33A4B186)]
        public float m_33A4B186 = 2f;
        
        [STUField(0x615EACEF)]
        public uint m_615EACEF = 0x19;
        
        [STUField(0xE700D46F)]
        public uint m_E700D46F = 0x384;
    }
}
