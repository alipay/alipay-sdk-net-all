using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsPayeeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsPayeeDTO : AopObject
    {
        /// <summary>
        /// 支付宝账号id：资金账号类型为支付宝时，必传
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 银行卡持卡人姓名:资金账号类型为银行卡时，必传
        /// </summary>
        [XmlElement("bank_card_holder_name")]
        public string BankCardHolderName { get; set; }

        /// <summary>
        /// 银行卡号:资金账号类型为银行卡时，必传
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 银行id
        /// </summary>
        [XmlElement("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 资金账号类型：ALIPAY( 支付宝),(BANK) 银行卡
        /// </summary>
        [XmlElement("bill_account_type")]
        public string BillAccountType { get; set; }

        /// <summary>
        /// 收款人用户id
        /// </summary>
        [XmlElement("payee_user_id")]
        public string PayeeUserId { get; set; }
    }
}
