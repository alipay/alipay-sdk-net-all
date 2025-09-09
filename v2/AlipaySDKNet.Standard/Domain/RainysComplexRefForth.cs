using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainysComplexRefForth Data Structure.
    /// </summary>
    [Serializable]
    public class RainysComplexRefForth : AopObject
    {
        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("object_string")]
        public string ObjectString { get; set; }
    }
}
