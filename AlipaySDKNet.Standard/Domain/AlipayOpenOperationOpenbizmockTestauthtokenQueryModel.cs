using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestauthtokenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTestauthtokenQueryModel : AopObject
    {
        /// <summary>
        /// 测试专用
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }
    }
}
