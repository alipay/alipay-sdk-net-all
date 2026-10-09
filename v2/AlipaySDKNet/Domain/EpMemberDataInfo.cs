using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpMemberDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpMemberDataInfo : AopObject
    {
        /// <summary>
        /// 企业成员列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_member_info")]
        public List<EpMemberInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
