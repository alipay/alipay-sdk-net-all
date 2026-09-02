using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentAgentTicketConfirmResponse.
    /// </summary>
    public class AlipayCommerceRentAgentTicketConfirmResponse : AopResponse
    {
        /// <summary>
        /// 用户咨询详情，由智能体在咨询过程中提取的结构化数据，各行业按 sub_biz_type 约定内部结构
        /// </summary>
        [XmlElement("consult_detail")]
        public ConsultDetail ConsultDetail { get; set; }
    }
}
