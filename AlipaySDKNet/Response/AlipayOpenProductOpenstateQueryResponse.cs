using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenProductOpenstateQueryResponse.
    /// </summary>
    public class AlipayOpenProductOpenstateQueryResponse : AopResponse
    {
        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("effect_date")]
        public string EffectDate { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("expiry_date")]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 返回产品开通状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
