using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AosDataItem Data Structure.
    /// </summary>
    [Serializable]
    public class AosDataItem : AopObject
    {
        /// <summary>
        /// 业务主键
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 原始数据
        /// </summary>
        [XmlElement("meta")]
        public string Meta { get; set; }
    }
}
