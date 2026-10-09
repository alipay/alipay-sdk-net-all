using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgWeatherWeeklyStats Data Structure.
    /// </summary>
    [Serializable]
    public class AgWeatherWeeklyStats : AopObject
    {
        /// <summary>
        /// 累计降水，单位mm*天
        /// </summary>
        [XmlElement("acc_precipitation")]
        public string AccPrecipitation { get; set; }

        /// <summary>
        /// 积温，单位摄氏度*天
        /// </summary>
        [XmlElement("acc_temperature")]
        public string AccTemperature { get; set; }

        /// <summary>
        /// 数据生产日期，YYYYMMDD
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 数据更新时间，YYYYMMDD
        /// </summary>
        [XmlElement("update_date")]
        public string UpdateDate { get; set; }
    }
}
