// Generated by TankLibHelper

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0x6CF1089B, "STUStatescriptWeaponProjectileEntity")]
    public class STUStatescriptWeaponProjectileEntity : STUInstance
    {
        [STUField(0x915AF62D)]
        public teStructuredDataAssetRef<STUEntityDefinition>[] m_915AF62D;
        
        [STUField(0x7DD89F4F, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVar m_entityDef;
        
        [STUField(0xA9A62FD0)]
        public byte m_A9A62FD0 = 0x1;
    }
}
