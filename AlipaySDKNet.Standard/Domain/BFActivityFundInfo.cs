using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BFActivityFundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BFActivityFundInfo : AopObject
    {
        /// <summary>
        /// 计收费主体是否激活
        /// </summary>
        [XmlElement("activity")]
        public bool Activity { get; set; }

        /// <summary>
        /// 老场景 活动模板ID
        /// </summary>
        [XmlElement("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// 签署的贴息协议ID
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 收费产品码
        /// </summary>
        [XmlElement("charge_code")]
        public string ChargeCode { get; set; }

        /// <summary>
        /// 老场景 活动ID
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 计收费减收配置ID
        /// </summary>
        [XmlElement("platform_subsidy_id")]
        public string PlatformSubsidyId { get; set; }

        /// <summary>
        /// bigdecimal subsidyMode=rate 表示折扣值 eg: 0.5 表示承担50%
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }

        /// <summary>
        /// 商家可见费率
        /// </summary>
        [XmlElement("seller_rate")]
        public string SellerRate { get; set; }

        /// <summary>
        /// rate:折扣,fixed:定额扣减
        /// </summary>
        [XmlElement("subsidy_mode")]
        public string SubsidyMode { get; set; }

        /// <summary>
        /// 贴息商户ID
        /// </summary>
        [XmlElement("subsidy_user")]
        public string SubsidyUser { get; set; }

        /// <summary>
        /// 期数信息
        /// </summary>
        [XmlElement("term")]
        public string Term { get; set; }

        /// <summary>
        /// 计收费主体类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
