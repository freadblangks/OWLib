// File auto generated by STUHashTool

using STULib.Types.Generic;

namespace STULib.Types {
    [STU(0x87C00EC0)]
    public class STUBrawlTeam : Common.STUInstance {
        [STUField(0x6F71E9AA)]
        public STUGamemodeVarValuePair[] m_6F71E9AA;

        [STUField(0xEA2B516F)]
        public STUGamemodeBodyVars[] HeroOverrides;

        [STUField(0xCF58324E)]
        public STUGamemodeVarValuePair[] m_CF58324E;

        [STUField(0x33B0B2B6, EmbeddedInstance = true)]
        public STUBrawlTeamTypeContainer BrawlTeamTypeContainer;

        [STUField(0x59C86C8D, EmbeddedInstance = true)]
        public STUCosmeticCollection AllowedHeroes;

        [STUField(0x341EF5FA)]
        public int MaxPlayers;
    }
}
