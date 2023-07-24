using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelAccountSyncaplusApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelAccountSyncaplusApplyModel : AopObject
    {
        /// <summary>
        /// A+ownerId
        /// </summary>
        [XmlElement("aplus_owner_id")]
        public string AplusOwnerId { get; set; }

        /// <summary>
        /// 跨境游ownerid
        /// </summary>
        [XmlElement("cn_owner_id")]
        public string CnOwnerId { get; set; }
    }
}
