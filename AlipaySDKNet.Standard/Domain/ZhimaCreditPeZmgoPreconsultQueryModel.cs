using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoPreconsultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoPreconsultQueryModel : AopObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务来源：阿里集团内传ALIBABA_INNER
        /// </summary>
        [XmlElement("biz_src")]
        public string BizSrc { get; set; }

        /// <summary>
        /// 业务类型：淘宝特价版传LITE_TAO
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
