using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppSdkTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppSdkTestQueryModel : AopObject
    {
        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("int_body")]
        public long IntBody { get; set; }

        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("string_str")]
        public string StringStr { get; set; }
    }
}
