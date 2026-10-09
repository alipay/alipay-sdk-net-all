using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantComplainReconciliationSubmitResponse.
    /// </summary>
    public class AlipayMerchantComplainReconciliationSubmitResponse : AopResponse
    {
        /// <summary>
        /// 商家的统一社会信用代码，间连商家则取二次认证后的统一社会信用代码
        /// </summary>
        [XmlElement("merchant_credit_no")]
        public string MerchantCreditNo { get; set; }

        /// <summary>
        /// 商家支付宝账号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家在支付宝侧的名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商家类型
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 对一些不影响12315一键和解流程开通，但是需要修改/优化的点进行提示
        /// </summary>
        [XmlElement("notice")]
        public string Notice { get; set; }
    }
}
