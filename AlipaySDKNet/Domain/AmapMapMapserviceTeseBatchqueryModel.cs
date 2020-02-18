using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmapMapMapserviceTeseBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AmapMapMapserviceTeseBatchqueryModel : AopObject
    {
        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("sed")]
        public string Sed { get; set; }
    }
}
