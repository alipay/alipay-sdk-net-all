using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCouponTemplateUserCreateResponse.
    /// </summary>
    public class AlipayFundCouponTemplateUserCreateResponse : AopResponse
    {
        /// <summary>
        /// 红包皮肤模板信息
        /// </summary>
        [XmlElement("template_info")]
        public GiftUserTemplateInfo TemplateInfo { get; set; }

        /// <summary>
        /// 和user_id一起，唯一标识发放给该用户的一个红包皮肤实例，需要业务方记录维护用户该皮肤实例的状态
        /// </summary>
        [XmlElement("user_template_id")]
        public string UserTemplateId { get; set; }
    }
}
