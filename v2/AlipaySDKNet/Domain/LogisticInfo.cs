using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticInfo : AopObject
    {
        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 物流详情
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 物流id
        /// </summary>
        [XmlElement("logistic_id")]
        public string LogisticId { get; set; }

        /// <summary>
        /// 发货地
        /// </summary>
        [XmlElement("ship_area")]
        public string ShipArea { get; set; }

        /// <summary>
        /// 发货时效
        /// </summary>
        [XmlElement("ship_period")]
        public string ShipPeriod { get; set; }

        /// <summary>
        /// 物流状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 物流停更时间
        /// </summary>
        [XmlElement("stop_update_time")]
        public string StopUpdateTime { get; set; }
    }
}
