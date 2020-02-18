using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceCertinfoQueryResponse.
    /// </summary>
    public class AlipayEcoCityserviceCertinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户证件信息查询结果列表。列表中的元素包含请求证件信息，以及对应的支付宝uid信息。
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("cert_info_response")]
        public List<CertInfoResponse> ResultList { get; set; }
    }
}
