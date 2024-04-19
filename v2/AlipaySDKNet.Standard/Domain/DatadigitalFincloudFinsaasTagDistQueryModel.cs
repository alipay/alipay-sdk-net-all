using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasTagDistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasTagDistQueryModel : AopObject
    {
        /// <summary>
        /// 标签展示类型
        /// </summary>
        [XmlElement("show_type")]
        public string ShowType { get; set; }

        /// <summary>
        /// 标签编码+唯一
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 标签版本
        /// </summary>
        [XmlElement("tag_version")]
        public long TagVersion { get; set; }
    }
}
