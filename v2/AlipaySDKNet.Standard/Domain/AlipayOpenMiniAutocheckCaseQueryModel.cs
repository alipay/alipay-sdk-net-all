using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAutocheckCaseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAutocheckCaseQueryModel : AopObject
    {
        /// <summary>
        /// 用例唯一主键ID
        /// </summary>
        [XmlElement("case_id")]
        public string CaseId { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [XmlElement("case_name")]
        public string CaseName { get; set; }
    }
}
