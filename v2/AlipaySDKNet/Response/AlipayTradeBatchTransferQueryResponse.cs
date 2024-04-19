using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeBatchTransferQueryResponse.
    /// </summary>
    public class AlipayTradeBatchTransferQueryResponse : AopResponse
    {
        /// <summary>
        /// 批量结算时传入的外部流水号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 批量结算详情
        /// </summary>
        [XmlArray("royalty_detail")]
        [XmlArrayItem("batch_royalty_detail")]
        public List<BatchRoyaltyDetail> RoyaltyDetail { get; set; }

        /// <summary>
        /// 结算单据号
        /// </summary>
        [XmlElement("settle_no")]
        public string SettleNo { get; set; }
    }
}
