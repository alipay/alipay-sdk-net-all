using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupervisionBillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SupervisionBillInfo : AopObject
    {
        /// <summary>
        /// 来账金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 来账单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 收方户名
        /// </summary>
        [XmlElement("payee_card_name")]
        public string PayeeCardName { get; set; }

        /// <summary>
        /// 收方卡号
        /// </summary>
        [XmlElement("payee_card_no")]
        public string PayeeCardNo { get; set; }

        /// <summary>
        /// 付方户名
        /// </summary>
        [XmlElement("payer_card_name")]
        public string PayerCardName { get; set; }

        /// <summary>
        /// 付方卡号
        /// </summary>
        [XmlElement("payer_card_no")]
        public string PayerCardNo { get; set; }

        /// <summary>
        /// 来账附言
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 来账时间
        /// </summary>
        [XmlElement("vostro_time")]
        public string VostroTime { get; set; }
    }
}
