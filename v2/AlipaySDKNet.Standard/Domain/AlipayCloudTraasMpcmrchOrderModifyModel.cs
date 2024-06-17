using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudTraasMpcmrchOrderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudTraasMpcmrchOrderModifyModel : AopObject
    {
        /// <summary>
        /// 客户详情
        /// </summary>
        [XmlElement("customer_detail")]
        public RentCustomerDetail CustomerDetail { get; set; }

        /// <summary>
        /// 鉴权的主体id，可以是手机号也可以是用户的身份证号等信息
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 风险校验的原子单位，可以是身份证号也可以是手机号等信息
        /// </summary>
        [XmlElement("customer_type")]
        public string CustomerType { get; set; }

        /// <summary>
        /// 配送详情
        /// </summary>
        [XmlElement("delivery_detail")]
        public RentDeliveryDetail DeliveryDetail { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        [XmlElement("item_detail")]
        public RentItemDetail ItemDetail { get; set; }

        /// <summary>
        /// 租赁的人工风控信息
        /// </summary>
        [XmlElement("manual_risk_detail")]
        public RentManualRiskDetail ManualRiskDetail { get; set; }

        /// <summary>
        /// 当前订单的创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 商户自身生成的订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 逾期的信息
        /// </summary>
        [XmlElement("overdue_detail")]
        public OverdueDetail OverdueDetail { get; set; }

        /// <summary>
        /// 租赁不同阶段的风控信息
        /// </summary>
        [XmlArray("phase_risk_details")]
        [XmlArrayItem("auto_rent_phase_risk_detail")]
        public List<AutoRentPhaseRiskDetail> PhaseRiskDetails { get; set; }

        /// <summary>
        /// 价格详情
        /// </summary>
        [XmlElement("price_detail")]
        public RentPriceDetail PriceDetail { get; set; }

        /// <summary>
        /// 订单的来源渠道
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 订单的状态同步
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
