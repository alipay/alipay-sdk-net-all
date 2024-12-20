using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpPatentDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpPatentDataInfo : AopObject
    {
        /// <summary>
        /// 查询命中明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_patent_info")]
        public List<EpPatentInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
