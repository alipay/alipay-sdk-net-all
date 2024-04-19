using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetVoucherTemplateInfoQuerybudgetResponse.
    /// </summary>
    public class AlipayAssetVoucherTemplateInfoQuerybudgetResponse : AopResponse
    {
        /// <summary>
        /// 券模板预算列表
        /// </summary>
        [XmlArray("template_list")]
        [XmlArrayItem("voucher_template_budget_d_t_o")]
        public List<VoucherTemplateBudgetDTO> TemplateList { get; set; }
    }
}
