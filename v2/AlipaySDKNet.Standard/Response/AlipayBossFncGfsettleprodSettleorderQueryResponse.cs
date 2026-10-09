using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsettleprodSettleorderQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettleprodSettleorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("pay_rcv_settle_order_d_t_o")]
        public List<PayRcvSettleOrderDTO> ResultSet { get; set; }
    }
}
