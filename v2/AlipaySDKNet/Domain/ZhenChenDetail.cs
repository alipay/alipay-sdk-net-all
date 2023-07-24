using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhenChenDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ZhenChenDetail : AopObject
    {
        /// <summary>
        /// 是个串
        /// </summary>
        [XmlElement("zhenchenstr")]
        public string Zhenchenstr { get; set; }

        /// <summary>
        /// 祯宸时间参数
        /// </summary>
        [XmlElement("zhenchentime")]
        public string Zhenchentime { get; set; }
    }
}
