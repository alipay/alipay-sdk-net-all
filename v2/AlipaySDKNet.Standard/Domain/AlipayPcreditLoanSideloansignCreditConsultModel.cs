using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanSideloansignCreditConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanSideloansignCreditConsultModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id，客户在支付宝的身份证
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// SIMPLE_CREDIT，极简授信
        /// </summary>
        [XmlElement("credit_type")]
        public string CreditType { get; set; }

        /// <summary>
        /// 外部渠道客户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 待补充
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
        /// 子授信模式
        /// </summary>
        [XmlElement("sub_credit_type")]
        public string SubCreditType { get; set; }
    }
}
