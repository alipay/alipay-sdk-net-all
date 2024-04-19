using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PublicTestProd Data Structure.
    /// </summary>
    [Serializable]
    public class PublicTestProd : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss")]
        public string Sss { get; set; }
    }
}
