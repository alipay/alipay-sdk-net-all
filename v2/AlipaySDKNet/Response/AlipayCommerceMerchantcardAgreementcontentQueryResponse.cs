using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardAgreementcontentQueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardAgreementcontentQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户在购卡的时候签署的协议内容
        /// </summary>
        [XmlElement("order_agreement_content")]
        public string OrderAgreementContent { get; set; }
    }
}
