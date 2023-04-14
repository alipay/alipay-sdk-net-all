using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtLandcoreLandcoretpspBpmSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtLandcoreLandcoretpspBpmSyncModel : AopObject
    {
        /// <summary>
        /// 蚂蚁方创建流程时对应的puid
        /// </summary>
        [XmlElement("puid")]
        public string Puid { get; set; }
    }
}
