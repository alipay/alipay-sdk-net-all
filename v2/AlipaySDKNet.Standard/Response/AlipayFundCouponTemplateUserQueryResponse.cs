using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCouponTemplateUserQueryResponse.
    /// </summary>
    public class AlipayFundCouponTemplateUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 用户封面列表
        /// </summary>
        [XmlArray("templates")]
        [XmlArrayItem("gift_user_template_box_info")]
        public List<GiftUserTemplateBoxInfo> Templates { get; set; }
    }
}
