using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCreditIsvwithdrawApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCreditIsvwithdrawApplyModel : AopObject
    {
        /// <summary>
        /// 支付宝支付流水号，请款必须与真实的支付宝交易对应
        /// </summary>
        [XmlElement("alipay_pay_no")]
        public string AlipayPayNo { get; set; }

        /// <summary>
        /// 请款金额，单位元，精度分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 企业统一社会信用代码
        /// </summary>
        [XmlElement("enterprise_code")]
        public string EnterpriseCode { get; set; }

        /// <summary>
        /// 企业码内部自动生成企业唯一标识
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 商户冻结单号
        /// </summary>
        [XmlElement("out_freeze_no")]
        public string OutFreezeNo { get; set; }

        /// <summary>
        /// 平台服务费金额， 单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("service_fee")]
        public string ServiceFee { get; set; }
    }
}
