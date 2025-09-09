using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayType Data Structure.
    /// </summary>
    [Serializable]
    public class PayType : AopObject
    {
        /// <summary>
        /// 如果是微信渠道，传bank_type字段 如果是支付宝渠道，拼装字段fund_channel|bank_code|fund_type，中间用英文竖线|间隔
        /// </summary>
        [XmlElement("payer_bank_type")]
        public string PayerBankType { get; set; }
    }
}
