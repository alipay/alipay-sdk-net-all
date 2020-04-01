using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BFActivityOpenApiInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BFActivityOpenApiInfo : AopObject
    {
        /// <summary>
        /// 活动收费配置信息
        /// </summary>
        [XmlArray("activity_fund_infos")]
        [XmlArrayItem("b_f_activity_fund_info")]
        public List<BFActivityFundInfo> ActivityFundInfos { get; set; }

        /// <summary>
        /// 活动模板ID
        /// </summary>
        [XmlElement("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// true 有效活动/false 失效活动
        /// </summary>
        [XmlElement("available")]
        public bool Available { get; set; }

        /// <summary>
        /// 开始期
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 时间类型
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 活动码信息
        /// </summary>
        [XmlElement("pc_id")]
        public string PcId { get; set; }

        /// <summary>
        /// 权益产品码
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 活动费率的版本信息
        /// </summary>
        [XmlElement("rate_version")]
        public string RateVersion { get; set; }
    }
}
