using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainysComplexRefThird Data Structure.
    /// </summary>
    [Serializable]
    public class RainysComplexRefThird : AopObject
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("ob_num")]
        public long ObNum { get; set; }

        /// <summary>
        /// 测试数据，无需关注
        /// </summary>
        [XmlElement("object_string")]
        public string ObjectString { get; set; }
    }
}
