using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepBiddingDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepBiddingDataInfo : AopObject
    {
        /// <summary>
        /// 企业工商招投标信息列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("zmep_bidding_info")]
        public List<ZmepBiddingInfo> Hits { get; set; }

        /// <summary>
        /// 结果条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
