using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdDfesfDefBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdDfesfDefBatchqueryModel : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("dd")]
        public GavintestNewLeveaOne Dd { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }
    }
}
