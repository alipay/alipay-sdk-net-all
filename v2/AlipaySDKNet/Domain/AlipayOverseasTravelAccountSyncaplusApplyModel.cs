using System;
using System.Xml.Serialization;
using System.Collections.Generic;

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

        /// <summary>
        /// 主账ownerId列表
        /// </summary>
        [XmlArray("cn_owner_ids")]
        [XmlArrayItem("string")]
        public List<string> CnOwnerIds { get; set; }
    }
}
