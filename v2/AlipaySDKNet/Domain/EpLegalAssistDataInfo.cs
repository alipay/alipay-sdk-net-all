using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpLegalAssistDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpLegalAssistDataInfo : AopObject
    {
        /// <summary>
        /// 查询内容明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_legal_assist_info")]
        public List<EpLegalAssistInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
