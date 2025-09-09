using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnifiedSettleTradeInstOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UnifiedSettleTradeInstOrderInfo : AopObject
    {
        /// <summary>
        /// 金额，币种为人民币，单位为元，1.00为一元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务备注，用于展示外部机构传递的备注
        /// </summary>
        [XmlElement("biz_memo")]
        public string BizMemo { get; set; }

        /// <summary>
        /// 该明细的创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 该明细的修改时间，比如最新一次的状态变更时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 来账外部机构的流水号，比如银行的流水号
        /// </summary>
        [XmlElement("inst_serial_no")]
        public string InstSerialNo { get; set; }

        /// <summary>
        /// 来账单据的单据号，作为主键标识每笔明细
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 付款方的账户名
        /// </summary>
        [XmlElement("payer_card_name")]
        public string PayerCardName { get; set; }

        /// <summary>
        /// 付款方的卡号
        /// </summary>
        [XmlElement("payer_card_no")]
        public string PayerCardNo { get; set; }

        /// <summary>
        /// 付款方机构/银行ID
        /// </summary>
        [XmlElement("payer_inst_id")]
        public string PayerInstId { get; set; }

        /// <summary>
        /// 该明细的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
