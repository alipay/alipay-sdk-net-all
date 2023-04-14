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
        /// 用户封面容器信息，包含封面生效时间区间以及封面、封底等图片、视频资源
        /// </summary>
        [XmlElement("gift_user_template_box_info")]
        public GiftUserTemplateBoxInfo GiftUserTemplateBoxInfo { get; set; }

        /// <summary>
        /// 红包封面模板信息
        /// </summary>
        [XmlElement("template_info")]
        public GiftUserTemplateInfo TemplateInfo { get; set; }

        /// <summary>
        /// 和user_id一起，唯一标识发放给该用户的一个红包封面实例，需要业务方记录维护用户该封面实例的状态
        /// </summary>
        [XmlElement("user_template_id")]
        public string UserTemplateId { get; set; }
    }
}
