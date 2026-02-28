using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncTaxIitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncTaxIitQueryModel : AopObject
    {
        /// <summary>
        /// 参数
        /// </summary>
        [XmlElement("iit_request")]
        public IitBizDetailBillQueryPageOpenApiDTO IitRequest { get; set; }
    }
}
