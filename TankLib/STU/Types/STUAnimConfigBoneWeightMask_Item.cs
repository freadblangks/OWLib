// Generated by TankLibHelper

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0x586361C8, "STUAnimConfigBoneWeightMask_Item")]
    public class STUAnimConfigBoneWeightMask_Item : STUInstance
    {
        [STUField(0x9CDDC24D, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_ABD8FE73 m_weight;
        
        [STUField(0xF97609C8)]
        public teStructuredDataAssetRef<STUBoneLabel> m_bone;
        
        [STUField(0xC7E4EB10)]
        public byte m_C7E4EB10;
        
        [STUField(0xA08C6C1C)]
        public byte m_A08C6C1C = 0x1;
    }
}
