using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPlanetsolutioncenterIsvBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationPlanetsolutioncenterIsvBindModel : AopObject
    {
        /// <summary>
        /// 解决方案唯一标识
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
