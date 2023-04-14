using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankMarketingBkcustgrowprodCardstyleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankMarketingBkcustgrowprodCardstyleCreateModel : AopObject
    {
        /// <summary>
        /// alipay_user_id, 不唯一，用于卡皮肤创建，无枚举值，支付宝uid
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// link_resource，跳转地址url，不唯一，无枚举值，特殊可选，当need_link为true时，该字段必填
        /// </summary>
        [XmlElement("link_resource")]
        public string LinkResource { get; set; }

        /// <summary>
        /// need_link，是否需要跳转，不唯一，无枚举值，Boolean类型，不传默认为false
        /// </summary>
        [XmlElement("need_link")]
        public bool NeedLink { get; set; }

        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// selected, 是否选中，不唯一，Boolean类型，不传默认为false
        /// </summary>
        [XmlElement("selected")]
        public bool Selected { get; set; }

        /// <summary>
        /// source，调用方，不唯一，用于识别调用方，无枚举值，此字段必传
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// style_origin_id，资源原始id，不唯一，无枚举值，对应水母原始订单号，此字段必传
        /// </summary>
        [XmlElement("style_origin_id")]
        public string StyleOriginId { get; set; }

        /// <summary>
        /// style_resource,网商卡皮肤url地址，不唯一，无枚举值，此字段必传
        /// </summary>
        [XmlElement("style_resource")]
        public string StyleResource { get; set; }

        /// <summary>
        /// template_id，网商皮肤模版id，不唯一，无枚举值，有网商进行分配，此字段必传
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
