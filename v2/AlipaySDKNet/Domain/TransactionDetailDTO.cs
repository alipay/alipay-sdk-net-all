using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransactionDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TransactionDetailDTO : AopObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 非实付金额列表
        /// </summary>
        [XmlArray("amount_modifiers")]
        [XmlArrayItem("transaction_amount_modifier_d_t_o")]
        public List<TransactionAmountModifierDTO> AmountModifiers { get; set; }

        /// <summary>
        /// 支付中断推进方式
        /// </summary>
        [XmlElement("authentication_details")]
        public TransactionAuthenticationDetailDTO AuthenticationDetails { get; set; }

        /// <summary>
        /// 条码id
        /// </summary>
        [XmlElement("barcode_identifier")]
        public string BarcodeIdentifier { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 卡id
        /// </summary>
        [XmlElement("dpan_identifier")]
        public string DpanIdentifier { get; set; }

        /// <summary>
        /// tradeNo
        /// </summary>
        [XmlElement("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 实付金额
        /// </summary>
        [XmlElement("nominal_amount")]
        public string NominalAmount { get; set; }

        /// <summary>
        /// 支付主渠道
        /// </summary>
        [XmlElement("primary_funding_source_description")]
        public string PrimaryFundingSourceDescription { get; set; }

        /// <summary>
        /// pId
        /// </summary>
        [XmlElement("raw_merchant_name")]
        public string RawMerchantName { get; set; }

        /// <summary>
        /// iso8601格式时间
        /// </summary>
        [XmlElement("transaction_date")]
        public string TransactionDate { get; set; }

        /// <summary>
        /// 交易标识
        /// </summary>
        [XmlElement("transaction_identifier")]
        public string TransactionIdentifier { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("transaction_status")]
        public string TransactionStatus { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("transaction_type")]
        public string TransactionType { get; set; }
    }
}
