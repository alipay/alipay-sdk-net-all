using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockDeleteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockDeleteQueryModel : AopObject
    {
        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("b_query")]
        public string BQuery { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("c_body")]
        public string CBody { get; set; }
    }
}
