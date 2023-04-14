using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceZhimaPreorderCreateResponse.
    /// </summary>
    public class AlipayCommerceZhimaPreorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 芝麻GO预创建单号
        /// </summary>
        [XmlElement("preorder_no")]
        public string PreorderNo { get; set; }
    }
}
