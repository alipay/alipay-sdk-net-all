using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingSrtaConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingSrtaConsultModel : AopObject
    {
        /// <summary>
        /// 多个手机号hash后的值，以为逗号分隔，通过手机号进行sha256加密后获取
        /// </summary>
        [XmlElement("anonymous_mobile_sha_256_list")]
        public string AnonymousMobileSha256List { get; set; }

        /// <summary>
        /// 目标用户一次加密密文信息，通过摩斯提供的sdk进行加密获得
        /// </summary>
        [XmlElement("blind_mobile_sha_256")]
        public string BlindMobileSha256 { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 订单金额，用标识订单的金额，可以不传
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 资源位信息确定商户投放场景，由摩斯同学配置并分配给调用方
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }
    }
}
