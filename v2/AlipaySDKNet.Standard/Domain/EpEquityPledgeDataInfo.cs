using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpEquityPledgeDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpEquityPledgeDataInfo : AopObject
    {
        /// <summary>
        /// 企业股权出质明细查询列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_equity_pledge_info")]
        public List<EpEquityPledgeInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
