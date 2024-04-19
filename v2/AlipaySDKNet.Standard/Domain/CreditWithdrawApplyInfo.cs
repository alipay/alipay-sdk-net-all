using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditWithdrawApplyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CreditWithdrawApplyInfo : AopObject
    {
        /// <summary>
        /// 支付宝流水号
        /// </summary>
        [XmlElement("alipay_pay_no")]
        public string AlipayPayNo { get; set; }

        /// <summary>
        /// 请款金额，单位元，精度分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
