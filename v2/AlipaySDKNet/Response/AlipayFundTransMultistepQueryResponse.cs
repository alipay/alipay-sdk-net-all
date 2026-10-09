using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransMultistepQueryResponse.
    /// </summary>
    public class AlipayFundTransMultistepQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单明细
        /// </summary>
        [XmlArray("order_details")]
        [XmlArrayItem("multi_step_trans_order_detail_response")]
        public List<MultiStepTransOrderDetailResponse> OrderDetails { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 请求方ID
        /// </summary>
        [XmlElement("request_user_id")]
        public string RequestUserId { get; set; }

        /// <summary>
        /// 转账总金额 单元：元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 转账明细总数量 （单位：条）
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
