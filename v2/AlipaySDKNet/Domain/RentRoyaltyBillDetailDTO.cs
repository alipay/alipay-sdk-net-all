using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRoyaltyBillDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentRoyaltyBillDetailDTO : AopObject
    {
        /// <summary>
        /// 资金类型
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 资方企业支付宝账户类型
        /// </summary>
        [XmlElement("invest_account_type")]
        public string InvestAccountType { get; set; }

        /// <summary>
        /// 资方银行卡号
        /// </summary>
        [XmlElement("invest_card_no")]
        public string InvestCardNo { get; set; }

        /// <summary>
        /// 租赁期数，单位：月
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 分账账单id
        /// </summary>
        [XmlElement("royalty_bill_id")]
        public string RoyaltyBillId { get; set; }

        /// <summary>
        /// 分账类型
        /// </summary>
        [XmlElement("royalty_deliver_type")]
        public string RoyaltyDeliverType { get; set; }

        /// <summary>
        /// 分账完成时间
        /// </summary>
        [XmlElement("royalty_finish_time")]
        public string RoyaltyFinishTime { get; set; }

        /// <summary>
        /// 分账履约单号
        /// </summary>
        [XmlElement("royalty_installment_no")]
        public string RoyaltyInstallmentNo { get; set; }

        /// <summary>
        /// 分账金额
        /// </summary>
        [XmlElement("royalty_price")]
        public string RoyaltyPrice { get; set; }

        /// <summary>
        /// 租赁阶段
        /// </summary>
        [XmlElement("stage")]
        public long Stage { get; set; }

        /// <summary>
        /// 分账交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
