using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionModifyResponse : AopResponse
    {
        /// <summary>
        /// 新增发放规则时返回外部幂等id和发放规则id的映射关系
        /// </summary>
        [XmlArray("issue_rule_id_info_list")]
        [XmlArrayItem("issue_rule_id_info")]
        public List<IssueRuleIdInfo> IssueRuleIdInfoList { get; set; }

        /// <summary>
        /// 修改是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 新增使用规则后会返回外部幂等id和使用规则id的映射关系
        /// </summary>
        [XmlArray("standard_id_info_list")]
        [XmlArrayItem("standard_id_info")]
        public List<StandardIdInfo> StandardIdInfoList { get; set; }
    }
}
