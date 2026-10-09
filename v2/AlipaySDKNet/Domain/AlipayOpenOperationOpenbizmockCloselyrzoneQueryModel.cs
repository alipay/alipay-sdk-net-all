using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockCloselyrzoneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockCloselyrzoneQueryModel : AopObject
    {
        /// <summary>
        /// 测试人员测试
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }
    }
}
