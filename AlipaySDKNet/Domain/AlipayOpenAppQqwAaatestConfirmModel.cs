using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppQqwAaatestConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppQqwAaatestConfirmModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("json")]
        public string Json { get; set; }
    }
}
