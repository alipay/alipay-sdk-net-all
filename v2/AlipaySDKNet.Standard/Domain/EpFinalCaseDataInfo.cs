using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpFinalCaseDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpFinalCaseDataInfo : AopObject
    {
        /// <summary>
        /// 查询命中内容明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_final_case_info")]
        public List<EpFinalCaseInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
