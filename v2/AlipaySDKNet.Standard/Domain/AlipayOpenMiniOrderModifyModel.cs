using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderModifyModel : AopObject
    {
        /// <summary>
        /// 商品修改信息
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("goods_info_modify_d_t_o")]
        public List<GoodsInfoModifyDTO> ItemInfos { get; set; }

        /// <summary>
        /// 用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 订单价格修改信息
        /// </summary>
        [XmlElement("price_info")]
        public PriceInfoModifyDTO PriceInfo { get; set; }

        /// <summary>
        /// 阶段付款计划列表，请在修改付款计划时传入
        /// </summary>
        [XmlArray("stage_pay_plans")]
        [XmlArrayItem("stage_pay_plan_d_t_o")]
        public List<StagePayPlanDTO> StagePayPlans { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
