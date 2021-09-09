using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeOrderSettleQueryResponse.
    /// </summary>
    public class AlipayTradeOrderSettleQueryResponse : AopResponse
    {
        /// <summary>
        /// 分账受理时间
        /// </summary>
        [XmlElement("operation_dt")]
        public string OperationDt { get; set; }

        /// <summary>
        /// 商户分账请求单号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账明细
        /// </summary>
        [XmlArray("royalty_detail_list")]
        [XmlArrayItem("royalty_detail")]
        public List<RoyaltyDetail> RoyaltyDetailList { get; set; }
    }
}
