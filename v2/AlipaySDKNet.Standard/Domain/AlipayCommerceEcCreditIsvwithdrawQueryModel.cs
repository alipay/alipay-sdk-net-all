using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCreditIsvwithdrawQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCreditIsvwithdrawQueryModel : AopObject
    {
        /// <summary>
        /// 请款时传入的支付宝支付流水号
        /// </summary>
        [XmlElement("alipay_pay_no")]
        public string AlipayPayNo { get; set; }

        /// <summary>
        /// 企业码内部自动生成企业唯一标识
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
