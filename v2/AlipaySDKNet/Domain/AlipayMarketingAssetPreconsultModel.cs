using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingAssetPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingAssetPreconsultModel : AopObject
    {
        /// <summary>
        /// 作为内部交易号使用
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务参数大字段，优惠咨询的控制参数，json格式；目前支持传入useBigAmountSkipOrderThold为N来控制不使用大金额跳过优惠的订单门槛检查；默认不传；
        /// </summary>
        [XmlElement("business_param")]
        public string BusinessParam { get; set; }

        /// <summary>
        /// 证件号码，例如身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，支持传入身份证类型：IDENTITY_CARD
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 商品咨询请求列表（当需要咨询单品券时必传，如果某商品不希望参与本次单品优惠咨询则不传递对应信息即可）
        /// </summary>
        [XmlArray("item_consult_list")]
        [XmlArrayItem("item_consult_request")]
        public List<ItemConsultRequest> ItemConsultList { get; set; }

        /// <summary>
        /// 出资的支付宝用户id 限制: 1、登录账号和用户ID必须且只能二选一
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单金额（如同时享受商户自有优惠请先扣除后传入），单位为元，最多2位小数
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 营销信息，包含promo_taobao等信息
        /// </summary>
        [XmlElement("promo_info")]
        public string PromoInfo { get; set; }

        /// <summary>
        /// 参考调用收银台的promoParams，如需咨询结果与拉起收银台一致需要保证这个参数一致
        /// </summary>
        [XmlElement("promo_rule")]
        public string PromoRule { get; set; }

        /// <summary>
        /// 场景码，每个业务场景独立分配
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 券指定的核销appid（如果配券时指定了核销范围为线上小程序及相应的appid则此处必传）
        /// </summary>
        [XmlElement("specified_app_id")]
        public string SpecifiedAppId { get; set; }

        /// <summary>
        /// 出资的支付宝用户id 限制: 1、登录账号和用户ID必须且只能二选一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
