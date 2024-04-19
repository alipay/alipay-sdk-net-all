using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleDetailResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SettleDetailResponse : AopObject
    {
        /// <summary>
        /// 分账金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 分账明细id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 分账比例
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 分账单ID
        /// </summary>
        [XmlElement("settle_order_id")]
        public string SettleOrderId { get; set; }

        /// <summary>
        /// 分账时间
        /// </summary>
        [XmlElement("settle_time")]
        public string SettleTime { get; set; }

        /// <summary>
        /// 分账接收方账号
        /// </summary>
        [XmlElement("trans_in_account")]
        public string TransInAccount { get; set; }
    }
}
