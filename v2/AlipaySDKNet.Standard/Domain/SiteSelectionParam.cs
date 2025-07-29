using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SiteSelectionParam Data Structure.
    /// </summary>
    [Serializable]
    public class SiteSelectionParam : AopObject
    {
        /// <summary>
        /// 全国统一城市编码（地级市级别），eg：北京市110100，杭州市330100
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 数据起始日期
        /// </summary>
        [XmlElement("date_from")]
        public string DateFrom { get; set; }

        /// <summary>
        /// 数据截止日期，请晚于起始日期
        /// </summary>
        [XmlElement("date_to")]
        public string DateTo { get; set; }

        /// <summary>
        /// 1. H3坐标网格编码。 2. 若为预测场站价格时，请传入互联互通场站编码。
        /// </summary>
        [XmlArray("index_list")]
        [XmlArrayItem("string")]
        public List<string> IndexList { get; set; }

        /// <summary>
        /// 经纬度列表
        /// </summary>
        [XmlArray("lng_lat_list")]
        [XmlArrayItem("lng_and_lat_param")]
        public List<LngAndLatParam> LngLatList { get; set; }

        /// <summary>
        /// 最短停留时长，单位为分钟
        /// </summary>
        [XmlElement("min_parking_period")]
        public long MinParkingPeriod { get; set; }

        /// <summary>
        /// 其他参数
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 车辆停留天数（单位：天）
        /// </summary>
        [XmlElement("parking_days")]
        public long ParkingDays { get; set; }

        /// <summary>
        /// 服务费
        /// </summary>
        [XmlElement("service_fee")]
        public string ServiceFee { get; set; }
    }
}
