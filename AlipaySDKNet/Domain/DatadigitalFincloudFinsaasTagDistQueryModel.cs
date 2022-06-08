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
        /// 标签编码+唯一
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
