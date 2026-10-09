using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppRefundBybillQueryResponse.
    /// </summary>
    public class AlipayEbppRefundBybillQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务受理平台业务28位订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 退款信息的集合
        /// </summary>
        [XmlArray("refund_info_list")]
        [XmlArrayItem("ebpp_refund_info")]
        public List<EbppRefundInfo> RefundInfoList { get; set; }
    }
}
