using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseAuthapplyBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseAuthapplyBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 企业认证申请记录列表
        /// </summary>
        [XmlArray("auth_apply_list")]
        [XmlArrayItem("enterprise_auth_apply_d_t_o")]
        public List<EnterpriseAuthApplyDTO> AuthApplyList { get; set; }
    }
}
