using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNcoilopenReferenceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNcoilopenReferenceCreateModel : AopObject
    {
        /// <summary>
        /// 行业解决方案id，不同场景对应的值不同，需要业务分配
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 解决方案id，不同场景对应的值不同，需要业务分配
        /// </summary>
        [XmlElement("sub_solution_id")]
        public string SubSolutionId { get; set; }

        /// <summary>
        /// 模板code，不同场景对应的值不同，需要业务分配
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
