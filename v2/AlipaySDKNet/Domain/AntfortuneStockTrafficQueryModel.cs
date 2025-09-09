using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockTrafficQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockTrafficQueryModel : AopObject
    {
        /// <summary>
        /// 机构标志
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 目标系统
        /// </summary>
        [XmlElement("traffic_code")]
        public string TrafficCode { get; set; }
    }
}
