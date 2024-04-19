using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplierAppendixUrl Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierAppendixUrl : AopObject
    {
        /// <summary>
        /// 图片名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 支持扩展名：jpg、png、jpeg
        /// </summary>
        [XmlElement("suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
