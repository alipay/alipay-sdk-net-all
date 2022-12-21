using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenBatchExpireVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class OpenBatchExpireVoucher : AopObject
    {
        /// <summary>
        /// 可用金额（废弃）
        /// </summary>
        [XmlElement("available_aount")]
        public long AvailableAount { get; set; }

        /// <summary>
        /// 可用次数
        /// </summary>
        [XmlElement("available_count")]
        public long AvailableCount { get; set; }

        /// <summary>
        /// 总金额（面额）
        /// </summary>
        [XmlElement("expire_amount")]
        public string ExpireAmount { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
