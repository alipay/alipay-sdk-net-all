using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppInstnoticeCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppInstnoticeCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 城市编码可选例如 320100：南京
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称：南京市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 公告结束时间 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 公告内容字符串数组 ["公告内容"]
        /// </summary>
        [XmlArray("notice_content")]
        [XmlArrayItem("string")]
        public List<string> NoticeContent { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 公告开始时间 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
