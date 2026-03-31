using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeIndfinsolCreditQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeIndfinsolCreditQueryModel : AopObject
    {
        /// <summary>
        /// 银行卡唯一标识
        /// </summary>
        [XmlElement("bank_card_token")]
        public string BankCardToken { get; set; }

        /// <summary>
        /// 业务场景类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }
    }
}
