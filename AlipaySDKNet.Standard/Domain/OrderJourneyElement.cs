using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderJourneyElement Data Structure.
    /// </summary>
    [Serializable]
    public class OrderJourneyElement : AopObject
    {
        /// <summary>
        /// 达到地信息
        /// </summary>
        [XmlElement("arrival")]
        public JourneyLocation Arrival { get; set; }

        /// <summary>
        /// 出发地信息
        /// </summary>
        [XmlElement("departure")]
        public JourneyLocation Departure { get; set; }

        /// <summary>
        /// 行程时长，单位为秒
        /// </summary>
        [XmlElement("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 结束时间（格式化）
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 结束时间描述（非结构化）
        /// </summary>
        [XmlElement("end_time_desc")]
        public string EndTimeDesc { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("order_ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 功能服务列表
        /// </summary>
        [XmlArray("functional_services")]
        [XmlArrayItem("functional_service")]
        public List<FunctionalService> FunctionalServices { get; set; }

        /// <summary>
        /// 出行人
        /// </summary>
        [XmlArray("passagers")]
        [XmlArrayItem("user_infomation")]
        public List<UserInfomation> Passagers { get; set; }

        /// <summary>
        /// 服务变更信息
        /// </summary>
        [XmlElement("service_change_info")]
        public JourneyServiceChangeInfo ServiceChangeInfo { get; set; }

        /// <summary>
        /// 服务提供方信息
        /// </summary>
        [XmlElement("service_provider")]
        public JourneyMerchantInfo ServiceProvider { get; set; }

        /// <summary>
        /// 开始时间格式化
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 开始时间描述（非格式化）
        /// </summary>
        [XmlElement("start_time_desc")]
        public string StartTimeDesc { get; set; }
    }
}
