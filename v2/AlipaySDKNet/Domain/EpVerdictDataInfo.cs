using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpVerdictDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpVerdictDataInfo : AopObject
    {
        /// <summary>
        /// 查询内容明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_verdict_info")]
        public List<EpVerdictInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
