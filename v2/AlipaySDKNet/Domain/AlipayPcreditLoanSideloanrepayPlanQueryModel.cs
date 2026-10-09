using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanSideloanrepayPlanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanSideloanrepayPlanQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 扩展信息，透传信息，预留
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 产品码, 信贷产品码销售外标 加 渠道编码组成，固定为: SL_PD_SALE_CODE-TAOTIAN
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 是否返回分期信息。true:接口会返回分期信息；false:接口不返回分期信息。
        /// </summary>
        [XmlElement("query_installment")]
        public bool QueryInstallment { get; set; }
    }
}
