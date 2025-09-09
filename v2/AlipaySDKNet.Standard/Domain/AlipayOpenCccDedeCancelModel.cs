using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenCccDedeCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenCccDedeCancelModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
