using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TravelRecord Data Structure.
    /// </summary>
    [Serializable]
    public class TravelRecord : AopObject
    {
        /// <summary>
        /// 当天公交乘车记录是否存在
        /// </summary>
        [XmlElement("bus_exist")]
        public bool BusExist { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 当天地铁记录是否存在
        /// </summary>
        [XmlElement("metro_exist")]
        public bool MetroExist { get; set; }
    }
}
