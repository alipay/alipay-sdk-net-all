using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyActionApplyResponse.
    /// </summary>
    public class AlipayUserCertifyActionApplyResponse : AopResponse
    {
        /// <summary>
        /// 返回给商户的支付宝业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
