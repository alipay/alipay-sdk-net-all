using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinInsuranceUnifiedApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinInsuranceUnifiedApplyModel : AopObject
    {
        /// <summary>
        /// 附加条款信息
        /// </summary>
        [XmlElement("additional_item")]
        public string AdditionalItem { get; set; }

        /// <summary>
        /// 投保人证件号码
        /// </summary>
        [XmlElement("apply_card_code")]
        public string ApplyCardCode { get; set; }

        /// <summary>
        /// 投保人证件类型 01-居民身份证 03-营业执照
        /// </summary>
        [XmlElement("apply_card_type")]
        public string ApplyCardType { get; set; }

        /// <summary>
        /// 投保人（企业或者自然人）名称
        /// </summary>
        [XmlElement("apply_name")]
        public string ApplyName { get; set; }

        /// <summary>
        /// 中台客户服务中的业务线编码
        /// </summary>
        [XmlElement("defin_business_code")]
        public string DefinBusinessCode { get; set; }

        /// <summary>
        /// 平台在客户服务中心的会员类型
        /// </summary>
        [XmlElement("defin_platform_access_type")]
        public string DefinPlatformAccessType { get; set; }

        /// <summary>
        /// 保险止期
        /// </summary>
        [XmlElement("insure_end_date")]
        public string InsureEndDate { get; set; }

        /// <summary>
        /// 保险起期
        /// </summary>
        [XmlElement("insure_start_date")]
        public string InsureStartDate { get; set; }

        /// <summary>
        /// 被保人证件号码
        /// </summary>
        [XmlElement("insured_card_code")]
        public string InsuredCardCode { get; set; }

        /// <summary>
        /// 被保人证件类型： 01-居民身份证 03-营业执照
        /// </summary>
        [XmlElement("insured_card_type")]
        public string InsuredCardType { get; set; }

        /// <summary>
        /// 被保人姓名
        /// </summary>
        [XmlElement("insured_name")]
        public string InsuredName { get; set; }

        /// <summary>
        /// 主险条款代码
        /// </summary>
        [XmlElement("main_item_code")]
        public string MainItemCode { get; set; }

        /// <summary>
        /// 主险条款内容
        /// </summary>
        [XmlElement("main_item_content")]
        public string MainItemContent { get; set; }

        /// <summary>
        /// 客户平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 保费，单位为：元（保留两位小数）
        /// </summary>
        [XmlElement("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 产品运营中心开通的产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 费率，最多兼容9位小数
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 业务线内全局唯一请求号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 特别约定
        /// </summary>
        [XmlElement("special")]
        public string Special { get; set; }

        /// <summary>
        /// 标的信息
        /// </summary>
        [XmlElement("subject_information")]
        public string SubjectInformation { get; set; }
    }
}
