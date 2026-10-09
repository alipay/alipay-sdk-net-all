using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpBranchDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpBranchDataInfo : AopObject
    {
        /// <summary>
        /// 查询内容明细
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_branch_detail_info")]
        public List<EpBranchDetailInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
