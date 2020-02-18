using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsMarketingCertificateBatchqueryResponse.
    /// </summary>
    public class AlipayInsMarketingCertificateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 分页查询结果
        /// </summary>
        [XmlElement("ins_certificate_pagination_list")]
        public InsCertificatePaginationList InsCertificatePaginationList { get; set; }
    }
}
