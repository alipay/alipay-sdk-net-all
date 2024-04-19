using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdGfsettleprodApplyQueryResponse.
    /// </summary>
    public class AlipayBossProdGfsettleprodApplyQueryResponse : AopResponse
    {
        /// <summary>
        /// 付款（开票）申请
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("payment_apply_response_d_t_o")]
        public List<PaymentApplyResponseDTO> ResultSet { get; set; }
    }
}
