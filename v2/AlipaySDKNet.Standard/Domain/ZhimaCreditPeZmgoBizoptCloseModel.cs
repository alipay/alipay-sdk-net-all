using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoBizoptCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoBizoptCloseModel : AopObject
    {
        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，由商户生成，请确保唯一性
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户Id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 芝麻GO配置模板Id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
