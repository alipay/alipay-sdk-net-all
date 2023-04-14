using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignOrderVoucherConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignOrderVoucherConsultModel : AopObject
    {
        /// <summary>
        /// 业务参数大字段，优惠咨询的控制参数，json格式；目前支持传入useBigAmountSkipOrderThold为N来控制不使用大金额跳过优惠的订单门槛检查；默认不传；
        /// </summary>
        [XmlElement("business_param")]
        public string BusinessParam { get; set; }

        /// <summary>
        /// 商品咨询请求列表（当需要咨询单品券时必传，如果某商品不希望参与本次单品优惠咨询则不传递对应信息即可）
        /// </summary>
        [XmlArray("item_consult_list")]
        [XmlArrayItem("item_consult_request")]
        public List<ItemConsultRequest> ItemConsultList { get; set; }

        /// <summary>
        /// 订单金额（如同时享受商户自有优惠请先扣除后传入），单位为元，最多2位小数
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 场景码：默认(DEFAULT)
        /// </summary>
        [XmlArray("scene_code")]
        [XmlArrayItem("string")]
        public List<string> SceneCode { get; set; }

        /// <summary>
        /// 券指定的核销appid（如果配券时指定了核销范围为线上小程序及相应的appid则此处必传）
        /// </summary>
        [XmlElement("specified_app_id")]
        public string SpecifiedAppId { get; set; }
    }
}
