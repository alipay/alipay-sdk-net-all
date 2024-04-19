using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSpayAuthConsultResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSpayAuthConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否通过了鉴权的校验，通过了为true，没有通过为false
        /// </summary>
        [XmlElement("auth_approved")]
        public bool AuthApproved { get; set; }

        /// <summary>
        /// 分次支付的支付信息，内部包含明细
        /// </summary>
        [XmlElement("multi_stage_pay_info")]
        public MultiStagePayInfo MultiStagePayInfo { get; set; }

        /// <summary>
        /// 用户没有通过鉴权的接口校验，未能通过的原因;如果用户是可用的，那么这个字段为空；
        /// </summary>
        [XmlElement("refuse_desc")]
        public string RefuseDesc { get; set; }
    }
}
