using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingRtaConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingRtaConsultModel : AopObject
    {
        /// <summary>
        /// 扩展字段，保留扩展配置字段
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// mobile_sha_256标识用户唯一信息，通过用户手机号SHA256 哈希后获得，openid和 mobile_sha256和uid三选一
        /// </summary>
        [XmlElement("mobile_sha_256")]
        public string MobileSha256 { get; set; }

        /// <summary>
        /// 支付宝用户的openid， openid和 mobile_sha256和uid三选一
        /// </summary>
        [XmlElement("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 订单金额，咨询时用于门槛值过滤，小于门槛值则不能投放，可以设置为空，表示不判断
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 资源位信息确定商户投放场景，由摩斯同学配置并分配给调用方
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 支付宝uid, openid和 mobile_sha256和uid三选一
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
