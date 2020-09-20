// Generated by TankLibHelper
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0x07A0E32F, "STULoadout")]
    public class STULoadout : STUInstance
    {
        [STUField(0xB48F1D22)]
        public teStructuredDataAssetRef<ulong> m_name;
        
        [STUField(0xCA7E6EDC)]
        public teStructuredDataAssetRef<ulong> m_description;
        
        [STUField(0xFC33191B)]
        public teStructuredDataAssetRef<ulong> m_logicalButton;
        
        [STUField(0x9290B942)]
        public teStructuredDataAssetRef<ulong> m_9290B942;
        
        [STUField(0x3CD6DC1E)]
        public teStructuredDataAssetRef<ulong> m_texture;
        
        [STUField(0xC8D38D7B)]
        public teStructuredDataAssetRef<ulong> m_infoMovie;
        
        [STUField(0x7E3ED979)]
        public teStructuredDataAssetRef<STUTargetTag>[] m_7E3ED979;
        
        [STUField(0xB1124918)]
        public teStructuredDataAssetRef<ulong>[] m_B1124918;
        
        [STUField(0x2C54AEAF)]
        public LoadoutCategory m_category;
        
        [STUField(0x0E679979)]
        public int m_0E679979 = -1;
    }
}
