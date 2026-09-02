using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdAppInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AdAppInfo : AopObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("series_app_id")]
        public string SeriesAppId { get; set; }
    }
}
