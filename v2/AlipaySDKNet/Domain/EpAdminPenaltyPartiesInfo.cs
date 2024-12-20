using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpAdminPenaltyPartiesInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpAdminPenaltyPartiesInfo : AopObject
    {
        /// <summary>
        /// 当事人名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 处罚详情
        /// </summary>
        [XmlArray("punish_details")]
        [XmlArrayItem("ep_admin_penalty_punish_details_info")]
        public List<EpAdminPenaltyPunishDetailsInfo> PunishDetails { get; set; }
    }
}
