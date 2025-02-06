using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepBiddingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepBiddingInfo : AopObject
    {
        /// <summary>
        /// 代理机构
        /// </summary>
        [XmlElement("agency_organization")]
        public string AgencyOrganization { get; set; }

        /// <summary>
        /// 中标人
        /// </summary>
        [XmlArray("bid_winner")]
        [XmlArrayItem("zmep_bidding_target_info")]
        public List<ZmepBiddingTargetInfo> BidWinner { get; set; }

        /// <summary>
        /// 正文
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 候选人
        /// </summary>
        [XmlArray("candidate")]
        [XmlArrayItem("zmep_bidding_target_info")]
        public List<ZmepBiddingTargetInfo> Candidate { get; set; }

        /// <summary>
        /// 公告类型
        /// </summary>
        [XmlElement("gglx")]
        public string Gglx { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// 采购人
        /// </summary>
        [XmlArray("purchasing_agent")]
        [XmlArrayItem("string")]
        public List<string> PurchasingAgent { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 身份
        /// </summary>
        [XmlArray("role")]
        [XmlArrayItem("string")]
        public List<string> Role { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 项目编号
        /// </summary>
        [XmlElement("xmbh")]
        public string Xmbh { get; set; }
    }
}
