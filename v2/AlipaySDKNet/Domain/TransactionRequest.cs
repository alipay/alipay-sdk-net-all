using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransactionRequest Data Structure.
    /// </summary>
    [Serializable]
    public class TransactionRequest : AopObject
    {
        /// <summary>
        /// 业务透传字段
        /// </summary>
        [XmlElement("biz_extend_info")]
        public string BizExtendInfo { get; set; }

        /// <summary>
        /// 下游唯一单号
        /// </summary>
        [XmlElement("ref_transfer_id")]
        public string RefTransferId { get; set; }

        /// <summary>
        /// 结算金额
        /// </summary>
        [XmlElement("settle_amount")]
        public TransferAmount SettleAmount { get; set; }
    }
}
