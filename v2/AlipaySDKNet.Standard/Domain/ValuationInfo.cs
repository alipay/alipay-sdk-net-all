using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ValuationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ValuationInfo : AopObject
    {
        /// <summary>
        /// 车辆估值金额，单位元
        /// </summary>
        [XmlElement("valuate_price")]
        public long ValuatePrice { get; set; }

        /// <summary>
        /// 车辆估值供应商
        /// </summary>
        [XmlElement("valuate_supplier")]
        public string ValuateSupplier { get; set; }

        /// <summary>
        /// 车辆估值时间
        /// </summary>
        [XmlElement("valuate_time")]
        public string ValuateTime { get; set; }
    }
}
