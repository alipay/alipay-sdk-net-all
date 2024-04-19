using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignTemplateQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 合同模板开放视图，注意如果是列表返回的是用于展示的精简值，详情请查询详情接口。
        /// </summary>
        [XmlElement("contract_template_open_vo")]
        public ContractTemplateOpenVO ContractTemplateOpenVo { get; set; }
    }
}
