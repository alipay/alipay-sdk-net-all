using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpConsumeRestrictionDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpConsumeRestrictionDataInfo : AopObject
    {
        /// <summary>
        /// 查询命中明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_consume_restriction_info")]
        public List<EpConsumeRestrictionInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
