using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsPreOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsPreOrderDTO : AopObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 预下单id
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 产品方案id
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }

        /// <summary>
        /// 报价信息
        /// </summary>
        [XmlElement("quote_info")]
        public InsQuoteDTO QuoteInfo { get; set; }

        /// <summary>
        /// 推荐流水id
        /// </summary>
        [XmlElement("recommend_flow_id")]
        public string RecommendFlowId { get; set; }

        /// <summary>
        /// 状态：INIT(初始化),ISSUED(已出单),CLOSE(关单)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
