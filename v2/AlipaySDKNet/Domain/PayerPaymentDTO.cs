using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayerPaymentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PayerPaymentDTO : AopObject
    {
        /// <summary>
        /// 付款渠道的真实姓名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 付款方式账号，如果是银行卡支付，该字段为卡号；如果支付余额支付该字段类型为用户uid
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 机构名称。如果支付方式不为银行卡，该字段不填
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 指定支付渠道。支持传入的值： 支付宝可用余额：AVAILABLE_BALANCE， 银行卡：BANK_CARD
        /// </summary>
        [XmlElement("pay_tool_type")]
        public string PayToolType { get; set; }
    }
}
