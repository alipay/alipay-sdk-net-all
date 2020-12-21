using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeOrdersQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeOrdersQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("recharge_order_tuition_d_t_o")]
        public List<RechargeOrderTuitionDTO> Data { get; set; }

        /// <summary>
        /// 当前分页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
