using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Airline Data Structure.
    /// </summary>
    [Serializable]
    public class Airline : AopObject
    {
        /// <summary>
        /// 票面航司二字码
        /// </summary>
        [XmlElement("ac_code")]
        public string AcCode { get; set; }

        /// <summary>
        /// 票面航司名称
        /// </summary>
        [XmlElement("ac_name")]
        public string AcName { get; set; }

        /// <summary>
        /// 票面航班号
        /// </summary>
        [XmlElement("flight_no")]
        public string FlightNo { get; set; }

        /// <summary>
        /// 是否是共享航班
        /// </summary>
        [XmlElement("is_share")]
        public bool IsShare { get; set; }

        /// <summary>
        /// 是否是经停航班
        /// </summary>
        [XmlElement("is_stop")]
        public bool IsStop { get; set; }

        /// <summary>
        /// 机型描述
        /// </summary>
        [XmlElement("plane_model")]
        public string PlaneModel { get; set; }

        /// <summary>
        /// 机型大小，一般为大、中、小，个别情况存在特殊机型
        /// </summary>
        [XmlElement("plane_model_size")]
        public string PlaneModelSize { get; set; }

        /// <summary>
        /// 共享航班主飞信息
        /// </summary>
        [XmlElement("share_airline")]
        public ShareAirline ShareAirline { get; set; }

        /// <summary>
        /// 经停信息
        /// </summary>
        [XmlArray("stop_info")]
        [XmlArrayItem("stop_info")]
        public List<StopInfo> StopInfo { get; set; }
    }
}
