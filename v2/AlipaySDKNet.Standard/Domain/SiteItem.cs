using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SiteItem Data Structure.
    /// </summary>
    [Serializable]
    public class SiteItem : AopObject
    {
        /// <summary>
        /// 经维度
        /// </summary>
        [XmlElement("lat_1")]
        public string Lat1 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [XmlElement("lat_2")]
        public string Lat2 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [XmlElement("lat_3")]
        public string Lat3 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [XmlElement("lat_4")]
        public string Lat4 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [XmlElement("lon_1")]
        public string Lon1 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [XmlElement("lon_2")]
        public string Lon2 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [XmlElement("lon_3")]
        public string Lon3 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [XmlElement("lon_4")]
        public string Lon4 { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 中心点经度
        /// </summary>
        [XmlElement("s_lat")]
        public string SLat { get; set; }

        /// <summary>
        /// 中心点维度
        /// </summary>
        [XmlElement("s_lon")]
        public string SLon { get; set; }

        /// <summary>
        /// 推荐打分
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 站点id
        /// </summary>
        [XmlElement("site_id")]
        public string SiteId { get; set; }
    }
}
