using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemRefundInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemRefundInfoVO : AopObject
    {
        /// <summary>
        /// 退款结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 退款开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 商品的退款状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
