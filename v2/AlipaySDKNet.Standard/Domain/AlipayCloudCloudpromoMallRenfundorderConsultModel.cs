using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallRenfundorderConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallRenfundorderConsultModel : AopObject
    {
        /// <summary>
        /// 退款类型
        /// </summary>
        [XmlElement("biz_claim_type")]
        public string BizClaimType { get; set; }

        /// <summary>
        /// 4: 未发货, 1: 未收到货, 2: 已收到货
        /// </summary>
        [XmlElement("goods_status")]
        public string GoodsStatus { get; set; }

        /// <summary>
        /// 子分销订单ID
        /// </summary>
        [XmlElement("order_line_id")]
        public string OrderLineId { get; set; }
    }
}
