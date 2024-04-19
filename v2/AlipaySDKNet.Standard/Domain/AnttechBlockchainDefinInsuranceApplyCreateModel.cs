using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinInsuranceApplyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinInsuranceApplyCreateModel : AopObject
    {
        /// <summary>
        /// 投保基本信息
        /// </summary>
        [XmlElement("apply_basic_info")]
        public ApplyBasicInfo ApplyBasicInfo { get; set; }

        /// <summary>
        /// 统一客户平台的业务线编码
        /// </summary>
        [XmlElement("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [XmlElement("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 产品市场编码，一般指保司端险种编码
        /// </summary>
        [XmlElement("pdt_mkt_code")]
        public string PdtMktCode { get; set; }

        /// <summary>
        /// 统一客户平台的会员类型
        /// </summary>
        [XmlElement("platform_access_type")]
        public string PlatformAccessType { get; set; }

        /// <summary>
        /// 统一客户平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 产品运营中心开通的产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 标的信息
        /// </summary>
        [XmlElement("subject_information")]
        public string SubjectInformation { get; set; }

        /// <summary>
        /// 唯一交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
