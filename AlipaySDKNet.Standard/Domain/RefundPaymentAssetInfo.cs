using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundPaymentAssetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RefundPaymentAssetInfo : AopObject
    {
        /// <summary>
        /// 银行卡结构id
        /// </summary>
        [XmlElement("bank_inst_id")]
        public string BankInstId { get; set; }

        /// <summary>
        /// 原充值单号
        /// </summary>
        [XmlElement("origin_order_id")]
        public string OriginOrderId { get; set; }

        /// <summary>
        /// 收款资产类型
        /// </summary>
        [XmlElement("receiver_asset_code")]
        public string ReceiverAssetCode { get; set; }

        /// <summary>
        /// 收款资产账号
        /// </summary>
        [XmlElement("receiver_asset_no")]
        public string ReceiverAssetNo { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        [XmlElement("receiver_logon_id")]
        public string ReceiverLogonId { get; set; }

        /// <summary>
        /// 单据退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
