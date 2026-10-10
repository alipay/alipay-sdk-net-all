using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundConfirmActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RefundConfirmActivityInfo : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 待退款的数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 退款确认活动的券码列表
        /// </summary>
        [XmlArray("voucher_code_list")]
        [XmlArrayItem("string")]
        public List<string> VoucherCodeList { get; set; }
    }
}
