// Generated by TankLibHelper
using TankLib.STU.Types.Enums;

// ReSharper disable All
namespace TankLib.STU.Types
{
    [STU(0xC7BAA017, 264)]
    public class STUStat : STUInstance
    {
        [STUField(0xB48F1D22, 8)] // size: 16
        public teStructuredDataAssetRef<ulong> m_name;

        [STUField(0x9F574E87, 24)] // size: 16
        public teStructuredDataAssetRef<ulong> m_9F574E87;

        [STUField(0x2F5D06B7, 40)] // size: 16
        public teStructuredDataAssetRef<STU_2A88312E>[] m_2F5D06B7;

        [STUField(0x4DD6BAFB, 56)] // size: 16
        public teStructuredDataAssetRef<STU_AB64F377> m_4DD6BAFB;

        [STUField(0xEF937A0D, 72)] // size: 16
        public teStructuredDataAssetRef<ulong> m_EF937A0D;

        [STUField(0x056D3E39, 88)] // size: 16
        public teStructuredDataAssetRef<STUHero>[] m_heroes;

        [STUField(0x6E01378E, 104)] // size: 16
        public teStructuredDataAssetRef<STUMap>[] m_maps;

        [STUField(0xD440A0F7, 120)] // size: 4
        public TeamIndex[] m_teams;

        [STUField(0x4C9917C1, 136)] // size: 16
        public teStructuredDataAssetRef<STUStat> m_4C9917C1;

        [STUField(0x155E2A47, 152)] // size: 16
        public teStructuredDataAssetRef<STUStat> m_155E2A47;

        [STUField(0x6EECB943, 168)] // size: 16
        public teStructuredDataAssetRef<STUStat>[] m_6EECB943;

        [STUField(0x57817968, 184, ReaderType = typeof(EmbeddedInstanceFieldReader))] // size: 8
        public STU_783B8A59 m_57817968;

        [STUField(0xBEA87015, 192)] // size: 4
        public STUStatDisplayType m_displayType;

        [STUField(0xF91D6DAD, 196)] // size: 4
        public STUStatCategory m_statCategory;

        [STUField(0x2FC4460C, 200)] // size: 4
        public Enum_CD0A8047 m_2FC4460C;

        [STUField(0xF3507330, 204)] // size: 4
        public Enum_3AA82AF1 m_F3507330;

        [STUField(0x0619C597, 208)] // size: 4
        public STUStatType m_type;

        [STUField(0x08CACF3A, 212)] // size: 4
        public STUStatUpdateType m_updateType;

        [STUField(0xA32E3245, 216)] // size: 4
        public Enum_58CDF4DE m_A32E3245 = Enum_58CDF4DE.xE30F4E68;

        [STUField(0x16CCEFC8, 220)] // size: 4
        public Enum_C9A3B99F m_16CCEFC8;

        [STUField(0x09276DD8, 224)] // size: 4
        public STUStatTimeframe m_timeFrame;

        [STUField(0xC6C4C538, 228)] // size: 4
        public STUPlayerStatEvent m_playerEvent;

        [STUField(0x0BB7C364, 232)] // size: 4
        public STUStatEvent m_primaryEvent;

        [STUField(0x33DDBA15, 236)] // size: 4
        public STUStatEvent m_secondaryEvent;

        [STUField(0xD0FEEC0E, 240)] // size: 4
        public STUStatHeroesType m_heroesType;

        [STUField(0x4811336B, 244)] // size: 4
        public STUStatMapsType m_mapsType;

        [STUField(0xDFD4F586, 248)] // size: 4
        public STUStatTeamsType m_teamsType;

        [STUField(0xC0211FD4, 252)] // size: 1
        public byte m_internalOnly;

        [STUField(0x9B42F159, 253)] // size: 1
        public byte m_9B42F159;

        [STUField(0x439EAAA8, 254)] // size: 1
        public byte m_439EAAA8;

        [STUField(0xEED826CD, 255)] // size: 1
        public byte m_derivedStat;

        [STUField(0xD0035CE1, 256)] // size: 1
        public byte m_D0035CE1 = 0x0;
    }
}
