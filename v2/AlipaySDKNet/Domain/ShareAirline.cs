using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShareAirline Data Structure.
    /// </summary>
    [Serializable]
    public class ShareAirline : AopObject
    {
        /// <summary>
        /// 共享航班主飞航司二字码
        /// </summary>
        [XmlElement("ac_code")]
        public string AcCode { get; set; }

        /// <summary>
        /// 共享航班主飞航司名称
        /// </summary>
        [XmlElement("ac_name")]
        public string AcName { get; set; }

        /// <summary>
        /// 共享航班主飞航班号
        /// </summary>
        [XmlElement("flight_no")]
        public string FlightNo { get; set; }

        /// <summary>
        /// 共享航班主飞机型
        /// </summary>
        [XmlElement("plane_model")]
        public string PlaneModel { get; set; }

        /// <summary>
        /// 共享航班主飞机型大小
        /// </summary>
        [XmlElement("plane_model_size")]
        public string PlaneModelSize { get; set; }
    }
}
