using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeDepositVerifyMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeDepositVerifyMatchModel : AopObject
    {
        /// <summary>
        /// 打款金额，单位：分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 打款验证ID 打款验证受理后生成的一个唯一标识
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
