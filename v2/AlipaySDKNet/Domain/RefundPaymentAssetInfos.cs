using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundPaymentAssetInfos Data Structure.
    /// </summary>
    [Serializable]
    public class RefundPaymentAssetInfos : AopObject
    {
        /// <summary>
        /// 银行卡机构id
        /// </summary>
        [XmlElement("bank_inst_id")]
        public string BankInstId { get; set; }

        /// <summary>
        /// 交易最后处理时间
        /// </summary>
        [XmlElement("execute_time")]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 原充值单号
        /// </summary>
        [XmlElement("origin_order_id")]
        public string OriginOrderId { get; set; }

        /// <summary>
        /// 交易总金额，单位元
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
        /// 单据退款金额，单位元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
