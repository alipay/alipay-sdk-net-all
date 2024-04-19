using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantagreementQueryResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantagreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 物流代扣协议的详细内容
        /// </summary>
        [XmlElement("agreement_detail")]
        public AgreementDetail AgreementDetail { get; set; }
    }
}
