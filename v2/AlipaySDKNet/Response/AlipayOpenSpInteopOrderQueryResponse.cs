using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpInteopOrderQueryResponse.
    /// </summary>
    public class AlipayOpenSpInteopOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 一体化作业主单号
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }

        /// <summary>
        /// 审核中
        /// </summary>
        [XmlElement("inteop_order_status")]
        public string InteopOrderStatus { get; set; }

        /// <summary>
        /// 一体化作业子项信息
        /// </summary>
        [XmlArray("inteop_sub_order_infos")]
        [XmlArrayItem("inte_op_sub_order_info")]
        public List<InteOpSubOrderInfo> InteopSubOrderInfos { get; set; }
    }
}
