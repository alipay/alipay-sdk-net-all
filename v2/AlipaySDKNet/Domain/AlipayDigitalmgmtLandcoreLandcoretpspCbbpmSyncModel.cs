using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtLandcoreLandcoretpspCbbpmSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtLandcoreLandcoretpspCbbpmSyncModel : AopObject
    {
        /// <summary>
        /// 流程唯一标识
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }
    }
}
