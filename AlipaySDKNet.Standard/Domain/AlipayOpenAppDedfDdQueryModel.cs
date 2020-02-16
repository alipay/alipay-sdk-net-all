using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppDedfDdQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppDedfDdQueryModel : AopObject
    {
        /// <summary>
        /// 10
        /// </summary>
        [XmlElement("zyde")]
        public string Zyde { get; set; }
    }
}
