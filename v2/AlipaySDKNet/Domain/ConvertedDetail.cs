using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConvertedDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ConvertedDetail : AopObject
    {
        /// <summary>
        /// 转化事件id
        /// </summary>
        [XmlElement("converted_id")]
        public string ConvertedId { get; set; }

        /// <summary>
        /// 转化事件名称
        /// </summary>
        [XmlElement("converted_name")]
        public string ConvertedName { get; set; }
    }
}
