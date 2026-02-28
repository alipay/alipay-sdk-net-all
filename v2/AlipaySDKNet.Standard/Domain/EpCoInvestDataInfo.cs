using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpCoInvestDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpCoInvestDataInfo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_co_invest_info")]
        public List<EpCoInvestInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
