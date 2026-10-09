using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiTrafficSourceChannelVO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiTrafficSourceChannelVO : AopObject
    {
        /// <summary>
        /// 一级来源渠道
        /// </summary>
        [XmlElement("first_source_type")]
        public string FirstSourceType { get; set; }

        /// <summary>
        /// 二级来源渠道,隶属于一级渠道
        /// </summary>
        [XmlElement("second_source_type")]
        public string SecondSourceType { get; set; }
    }
}
