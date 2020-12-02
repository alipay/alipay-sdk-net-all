using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceApplystatusQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceApplystatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 每笔交易开票状态
        /// </summary>
        [XmlArray("apply_status_brief_dtos")]
        [XmlArrayItem("order_apply_status_brief_d_t_o")]
        public List<OrderApplyStatusBriefDTO> ApplyStatusBriefDtos { get; set; }
    }
}
