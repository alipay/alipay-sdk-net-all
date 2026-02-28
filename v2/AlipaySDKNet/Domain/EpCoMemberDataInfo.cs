using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpCoMemberDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpCoMemberDataInfo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_co_member_info")]
        public List<EpCoMemberInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
