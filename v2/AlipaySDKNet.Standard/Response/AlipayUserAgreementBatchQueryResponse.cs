using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAgreementBatchQueryResponse.
    /// </summary>
    public class AlipayUserAgreementBatchQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户签约协议列表
        /// </summary>
        [XmlArray("usage_agreement_info_list")]
        [XmlArrayItem("open_api_sign_query_response")]
        public List<OpenApiSignQueryResponse> UsageAgreementInfoList { get; set; }
    }
}
