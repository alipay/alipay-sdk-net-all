using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignTemplateBatchqueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignTemplateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 合同模板查询列表返回值，注意如果是列表返回的是用于展示的精简值，详情请查询详情接口。
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("contract_template_open_v_o")]
        public List<ContractTemplateOpenVO> DataList { get; set; }

        /// <summary>
        /// 页，默认1，必须要大于0。
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小，默认10。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 列表记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
