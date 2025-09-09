using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpInvestDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpInvestDataInfo : AopObject
    {
        /// <summary>
        /// 企业对外投资明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_invest_info")]
        public List<EpInvestInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
