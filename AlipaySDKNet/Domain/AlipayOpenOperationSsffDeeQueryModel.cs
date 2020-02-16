using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationSsffDeeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationSsffDeeQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("df")]
        public string Df { get; set; }
    }
}
