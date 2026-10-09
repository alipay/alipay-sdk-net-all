using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsActivityAccessConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsActivityAccessConsultModel : AopObject
    {
        /// <summary>
        /// 约定值，可找对接方技术确认，数字和字母组成的字符，长度在8-32之间
        /// </summary>
        [XmlElement("activity_key")]
        public string ActivityKey { get; set; }

        /// <summary>
        /// 支付宝侧得uid，通过openId映射
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝侧得uid，通过openId映射
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
