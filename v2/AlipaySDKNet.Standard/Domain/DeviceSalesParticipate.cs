using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceSalesParticipate Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceSalesParticipate : AopObject
    {
        /// <summary>
        /// 活动 id（做任务得设备、先采后返的时候必有）
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 卖进订单id（有卖进活动的时候必有）
        /// </summary>
        [XmlElement("sales_entry_order_id")]
        public string SalesEntryOrderId { get; set; }

        /// <summary>
        /// 卖进方案id
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }
    }
}
