using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupvFundTransferDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SupvFundTransferDetail : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 发生时间
        /// </summary>
        [XmlElement("occurred_time")]
        public string OccurredTime { get; set; }

        /// <summary>
        /// 结算单号
        /// </summary>
        [XmlElement("settle_order_no")]
        public string SettleOrderNo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 转账类型
        /// </summary>
        [XmlElement("transfer_type")]
        public string TransferType { get; set; }
    }
}
