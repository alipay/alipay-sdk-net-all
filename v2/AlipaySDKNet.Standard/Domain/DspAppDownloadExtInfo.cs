using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DspAppDownloadExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DspAppDownloadExtInfo : AopObject
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 应用下载属性值
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
