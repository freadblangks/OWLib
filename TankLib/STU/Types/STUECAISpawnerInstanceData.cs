// Generated by TankLibHelper
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0x99257985, "STUECAISpawnerInstanceData")]
    public class STUECAISpawnerInstanceData : STUComponentInstanceData
    {
        [STUField(0xE74A5F9A)]
        public teStructuredDataAssetRef<STUHero> m_E74A5F9A;
        
        [STUField(0xEF29ED01)]
        public teStructuredDataAssetRef<STUIdentifier> m_EF29ED01;
        
        [STUField(0xE5CEAD94, ReaderType = typeof(InlineInstanceFieldReader))]
        public STUStatescriptGraphWithOverrides[] m_E5CEAD94;
        
        [STUField(0xCD66847E)]
        public TeamIndex m_CD66847E;
        
        [STUField(0x8A10B520)]
        public byte m_8A10B520 = 0x1;
        
        [STUField(0x44AB45F0)]
        public byte m_44AB45F0 = 0x1;
    }
}
