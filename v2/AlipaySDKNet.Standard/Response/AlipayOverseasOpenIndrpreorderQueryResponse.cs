using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenIndrpreorderQueryResponse.
    /// </summary>
    public class AlipayOverseasOpenIndrpreorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 付款金额
        /// </summary>
        [XmlElement("payment_amount")]
        public IndrISVAmountInfoDTO PaymentAmount { get; set; }

        /// <summary>
        /// 预下单订单号
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public IndrISVAmountInfoDTO RefundAmount { get; set; }

        /// <summary>
        /// 查询结果
        /// </summary>
        [XmlElement("result")]
        public IndrISVResult Result { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        [XmlElement("status")]
        public IndrISVOrderStatusDTO Status { get; set; }
    }
}
