using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppMarketingConsultResponse.
    /// </summary>
    public class AlipayPayAppMarketingConsultResponse : AopResponse
    {
        /// <summary>
        /// 反作弊等级值；仅当请求入参need_query_anti_rank为true时才会返回
        /// </summary>
        [XmlElement("anti_rank")]
        public string AntiRank { get; set; }

        /// <summary>
        /// 指定优惠信息；商户无需关注内容，调用收单支付接口时需将此字段的取值放在promo_params中透传带入，key为assignDiscounts
        /// </summary>
        [XmlElement("assign_discounts")]
        public string AssignDiscounts { get; set; }

        /// <summary>
        /// 业务标签；当请求入参need_return_tag为true时才会返回
        /// </summary>
        [XmlElement("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// name String 人群标签名称 bindCard 用户匹配到的人群标签。枚举示例 引导绑卡：bindCard?引导绑信用卡：bindCreditCard?引导花呗签约：huabeiSign extParams Map<String,String> 扩展参数 {"url":"xxx"} 标签对应的扩展信息。类似本次新增的跳转链接地址
        /// </summary>
        [XmlArray("biz_tag_entity_list")]
        [XmlArrayItem("biz_tag_entity")]
        public List<BizTagEntity> BizTagEntityList { get; set; }

        /// <summary>
        /// 返回前置咨询用户命中的人群标签，如用户在花呗设首人群中，则透出ALICREDIT_PRIORITY，命中多个标签时以列表形式返回
        /// </summary>
        [XmlArray("biz_tag_list")]
        [XmlArrayItem("string")]
        public List<string> BizTagList { get; set; }

        /// <summary>
        /// 仅当请求使用morse匿名技术时会返回此字段； morse匿名技术使用的盲签名，商户使用此值与私钥一起对混淆后的密文结果进行解密；解密后结果为json格式字符串，可以json反序列化后，获取对应的文案(key为text)；若无文案则解密后为空
        /// </summary>
        [XmlElement("blind_signature")]
        public string BlindSignature { get; set; }

        /// <summary>
        /// 例如：亲情卡支付渠道信息、银行卡渠道优惠信息等
        /// </summary>
        [XmlArray("channel_info_list")]
        [XmlArrayItem("pay_channel_promo_info")]
        public List<PayChannelPromoInfo> ChannelInfoList { get; set; }

        /// <summary>
        /// 仅当请求使用morse匿名技术时会返回此字段； morse匿名技术产出的混淆后的密文结果，需使用商户私钥及接口返回的盲签名对密文进行解密；解密后结果为json格式字符串，可以json反序列化后，获取对应的文案(key为text)；若无文案则解密后为空
        /// </summary>
        [XmlArray("confused_cipher_list")]
        [XmlArrayItem("string")]
        public List<string> ConfusedCipherList { get; set; }

        /// <summary>
        /// 优惠额度信息
        /// </summary>
        [XmlArray("discount_quota_infos")]
        [XmlArrayItem("discount_quota_info")]
        public List<DiscountQuotaInfo> DiscountQuotaInfos { get; set; }

        /// <summary>
        /// 已废弃不再使用
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 营销偏好等级值；仅当请求入参need_query_marketing_rank为true时才会返回
        /// </summary>
        [XmlElement("marketing_rank")]
        public string MarketingRank { get; set; }

        /// <summary>
        /// 支付运营扩展信息；商户无需关注内容，调用收单支付接口时需将此字段的取值放在business_params中透传带入，key为payOperationInfo
        /// </summary>
        [XmlElement("pay_operation_info")]
        public string PayOperationInfo { get; set; }

        /// <summary>
        /// 前置咨询ID,用来标识本次请求
        /// </summary>
        [XmlElement("pre_consult_id")]
        public string PreConsultId { get; set; }

        /// <summary>
        /// 已废弃不再使用
        /// </summary>
        [XmlElement("pre_pay_token")]
        public string PrePayToken { get; set; }

        /// <summary>
        /// 营销文案文本内容（使用morse匿名方案时不返回此字段，需要从返回的密文中解密获取）
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
