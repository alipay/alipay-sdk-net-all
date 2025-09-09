using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpExecuteDefendantDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpExecuteDefendantDataInfo : AopObject
    {
        /// <summary>
        /// 查询内容明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_execute_defendant_info")]
        public List<EpExecuteDefendantInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
