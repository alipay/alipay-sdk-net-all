using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniBillCertQueryResponse.
    /// </summary>
    public class AlipayOpenMiniBillCertQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询返回的账单
        /// </summary>
        [XmlArray("response")]
        [XmlArrayItem("cert_bill_detail")]
        public List<CertBillDetail> Response { get; set; }
    }
}
