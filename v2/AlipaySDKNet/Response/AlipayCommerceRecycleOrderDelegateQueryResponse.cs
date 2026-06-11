using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleOrderDelegateQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleOrderDelegateQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单权益信息
        /// </summary>
        [XmlArray("benefits")]
        [XmlArrayItem("recycle_order_benefit_v_o")]
        public List<RecycleOrderBenefitVO> Benefits { get; set; }

        /// <summary>
        /// 订单基础信息
        /// </summary>
        [XmlElement("order_base")]
        public RecycleStdOrderBaseVO OrderBase { get; set; }

        /// <summary>
        /// 订单履约信息
        /// </summary>
        [XmlElement("order_delivery")]
        public RecycleDeliveryVO OrderDelivery { get; set; }

        /// <summary>
        /// 订单资金信息
        /// </summary>
        [XmlElement("order_fund_all")]
        public RecycleOrderFundAllVO OrderFundAll { get; set; }

        /// <summary>
        /// 品牌膨胀金信息
        /// </summary>
        [XmlElement("order_fund_subsidy")]
        public RecycleStdOrderFundSubSidyVO OrderFundSubsidy { get; set; }

        /// <summary>
        /// 回收商户信息
        /// </summary>
        [XmlElement("order_merchant")]
        public RecycleStdOrderMerchantInfoVO OrderMerchant { get; set; }

        /// <summary>
        /// 商户履约信息
        /// </summary>
        [XmlElement("order_merchant_delivery")]
        public RecycleDeliveryVO OrderMerchantDelivery { get; set; }

        /// <summary>
        /// 订单退货信息
        /// </summary>
        [XmlElement("order_sendback")]
        public RecycleDeliveryVO OrderSendback { get; set; }

        /// <summary>
        /// 订单标签信息
        /// </summary>
        [XmlArray("order_tags")]
        [XmlArrayItem("recycle_order_tag_info_v_o")]
        public List<RecycleOrderTagInfoVO> OrderTags { get; set; }

        /// <summary>
        /// 订单关联信息
        /// </summary>
        [XmlArray("relation_infos")]
        [XmlArrayItem("recycle_order_relation_v_o")]
        public List<RecycleOrderRelationVO> RelationInfos { get; set; }
    }
}
