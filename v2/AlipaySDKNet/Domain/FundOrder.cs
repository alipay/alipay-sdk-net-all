using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundOrder Data Structure.
    /// </summary>
    [Serializable]
    public class FundOrder : AopObject
    {
        /// <summary>
        /// 订单金额。单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 商户交易创建时间，可用于双方对账。标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单币种
        /// </summary>
        [XmlElement("order_currency")]
        public string OrderCurrency { get; set; }

        /// <summary>
        /// 交易超时自动关单时间
        /// </summary>
        [XmlElement("order_expiry_time")]
        public string OrderExpiryTime { get; set; }

        /// <summary>
        /// 交易类型，ACQUIRE 收单业务；DEPOSIT 纯资金充值业务；TRANSFER 纯资金转账业务；WITHDRAW 纯资金提现业务
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部业务平台原始交易号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 收款方外部业务平台会员ID，充值，提现不用填，转账给非云企付会员不用填
        /// </summary>
        [XmlElement("payee_out_member_id")]
        public ReferenceId PayeeOutMemberId { get; set; }

        /// <summary>
        /// 付款方外部业务平台会员ID
        /// </summary>
        [XmlElement("payer_out_member_id")]
        public ReferenceId PayerOutMemberId { get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
