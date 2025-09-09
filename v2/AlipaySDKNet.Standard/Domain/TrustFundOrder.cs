using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrustFundOrder Data Structure.
    /// </summary>
    [Serializable]
    public class TrustFundOrder : AopObject
    {
        /// <summary>
        /// 划拨金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 机构侧资金划拨流水，机构侧唯一。和机构侧对账使用
        /// </summary>
        [XmlElement("channel_order_id")]
        public string ChannelOrderId { get; set; }

        /// <summary>
        /// 资金单状态
        /// </summary>
        [XmlElement("fund_status")]
        public string FundStatus { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [XmlElement("payee_account_no")]
        public string PayeeAccountNo { get; set; }

        /// <summary>
        /// 收款方账号类型
        /// </summary>
        [XmlElement("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 收款方（账号）名称
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 付款方账号
        /// </summary>
        [XmlElement("payer_account_no")]
        public string PayerAccountNo { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("payer_account_type")]
        public string PayerAccountType { get; set; }

        /// <summary>
        /// 付款方（账号）名称
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
