using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDddDdPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDddDdPayModel : AopObject
    {
        /// <summary>
        /// test case
        /// </summary>
        [XmlElement("dem_ref")]
        public RainyComplexTypesTheten DemRef { get; set; }
    }
}
