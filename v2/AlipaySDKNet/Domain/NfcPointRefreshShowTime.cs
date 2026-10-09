using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcPointRefreshShowTime Data Structure.
    /// </summary>
    [Serializable]
    public class NfcPointRefreshShowTime : AopObject
    {
        /// <summary>
        /// 展示结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 展示结束时间，毫秒时间戳
        /// </summary>
        [XmlElement("end_date_time_stamp")]
        public long EndDateTimeStamp { get; set; }

        /// <summary>
        /// 展示开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 展示开始时间，毫秒时间戳
        /// </summary>
        [XmlElement("start_date_time_stamp")]
        public long StartDateTimeStamp { get; set; }
    }
}
