using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechQqqCccQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechQqqCccQueryModel : AopObject
    {
        /// <summary>
        /// dh
        /// </summary>
        [XmlElement("babab")]
        public string Babab { get; set; }

        /// <summary>
        /// dgbhr
        /// </summary>
        [XmlElement("er_1_openid")]
        public string Er1Openid { get; set; }

        /// <summary>
        /// 和金龟换酒那几个号结构化
        /// </summary>
        [XmlElement("pppp")]
        public string Pppp { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// dgbhr
        /// </summary>
        [XmlElement("re")]
        public string Re { get; set; }
    }
}
