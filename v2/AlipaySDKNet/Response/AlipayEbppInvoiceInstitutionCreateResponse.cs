using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionCreateResponse : AopResponse
    {
        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 发放规则id列表
        /// </summary>
        [XmlArray("issue_rule_id_info_list")]
        [XmlArrayItem("issue_rule_id_info")]
        public List<IssueRuleIdInfo> IssueRuleIdInfoList { get; set; }

        /// <summary>
        /// 使用规则id列表
        /// </summary>
        [XmlArray("standard_id_info_list")]
        [XmlArrayItem("standard_id_info")]
        public List<StandardIdInfo> StandardIdInfoList { get; set; }
    }
}
