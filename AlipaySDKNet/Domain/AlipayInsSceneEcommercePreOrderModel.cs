using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommercePreOrderModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommercePreOrderModel : AopObject
    {
        /// <summary>
        /// 买家
        /// </summary>
        [XmlElement("buyer")]
        public EcomBuyerDTO Buyer { get; set; }

        /// <summary>
        /// 是否需要核验保障方案定价
        /// </summary>
        [XmlElement("check_quote")]
        public bool CheckQuote { get; set; }

        /// <summary>
        /// 用户选定的保障方案
        /// </summary>
        [XmlElement("insure_plan_dto")]
        public InsurePlanDTO InsurePlanDto { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        [XmlElement("item")]
        public EcomItemDTO Item { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("order_dto")]
        public EcomOrderDTO OrderDto { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 推荐流水id
        /// </summary>
        [XmlElement("recommend_flow_id")]
        public string RecommendFlowId { get; set; }

        /// <summary>
        /// 卖家
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }

        /// <summary>
        /// 回溯记录
        /// </summary>
        [XmlArray("trace_list")]
        [XmlArrayItem("ins_user_trace_d_t_o")]
        public List<InsUserTraceDTO> TraceList { get; set; }

        /// <summary>
        /// 客户端渠道:ios / android / pc / wx_applet(微信小程序)
        /// </summary>
        [XmlElement("user_client")]
        public string UserClient { get; set; }
    }
}
