using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItempromoactivityTemplateQueryResponse.
    /// </summary>
    public class AlipayOpenAppItempromoactivityTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 可准入的方法
        /// </summary>
        [XmlElement("access_action")]
        public PromoActivityAccessActionVO AccessAction { get; set; }

        /// <summary>
        /// 属性列表
        /// </summary>
        [XmlArray("activity_attrs")]
        [XmlArrayItem("promo_activity_attr_v_o")]
        public List<PromoActivityAttrVO> ActivityAttrs { get; set; }

        /// <summary>
        /// 描述商品营销活动
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 营销活动类型
        /// </summary>
        [XmlElement("promotion_type")]
        public string PromotionType { get; set; }

        /// <summary>
        /// 小程序是否准入
        /// </summary>
        [XmlElement("proved")]
        public bool Proved { get; set; }

        /// <summary>
        /// 描述不准入原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 营销活动标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
