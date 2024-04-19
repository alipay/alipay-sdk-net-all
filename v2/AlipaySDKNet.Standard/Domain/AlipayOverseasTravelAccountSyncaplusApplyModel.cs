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
        /// AplusOwner的邮箱
        /// </summary>
        [XmlElement("aplus_owner_email")]
        public string AplusOwnerEmail { get; set; }

        /// <summary>
        /// A+ownerId
        /// </summary>
        [XmlElement("aplus_owner_id")]
        public string AplusOwnerId { get; set; }

        /// <summary>
        /// aplusOwner名称
        /// </summary>
        [XmlElement("aplus_owner_name")]
        public string AplusOwnerName { get; set; }

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

        /// <summary>
        /// CN的pid
        /// </summary>
        [XmlElement("cn_trade_pid")]
        public string CnTradePid { get; set; }
    }
}
