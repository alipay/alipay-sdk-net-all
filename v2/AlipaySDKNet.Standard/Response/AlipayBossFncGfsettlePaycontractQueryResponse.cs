using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsettlePaycontractQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettlePaycontractQueryResponse : AopResponse
    {
        /// <summary>
        /// 付款条款
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("pay_contract_item_apply_d_t_o")]
        public List<PayContractItemApplyDTO> ResultSet { get; set; }
    }
}
