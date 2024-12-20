using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpAdminPenaltyDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpAdminPenaltyDataInfo : AopObject
    {
        /// <summary>
        /// 查询企业行政处罚明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_admin_penalty_info")]
        public List<EpAdminPenaltyInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
