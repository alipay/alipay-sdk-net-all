using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCertificateCertificatetionSendcallbackResponse.
    /// </summary>
    public class AlipayMarketingCertificateCertificatetionSendcallbackResponse : AopResponse
    {
        /// <summary>
        /// 商品购买后生成的凭证明细
        /// </summary>
        [XmlArray("certificate_info_list")]
        [XmlArrayItem("certificate_query_info")]
        public List<CertificateQueryInfo> CertificateInfoList { get; set; }

        /// <summary>
        /// 购买商品的订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
