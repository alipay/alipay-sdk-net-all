using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrivilegeBenefit Data Structure.
    /// </summary>
    [Serializable]
    public class PrivilegeBenefit : AopObject
    {
        /// <summary>
        /// 权益内容，KV形式
        /// </summary>
        [XmlElement("benefit_context")]
        public string BenefitContext { get; set; }

        /// <summary>
        /// 整体以{"key":[value1, value2]}的结构传参，通过K-V的形式传递，需要与开发人员指定规则code。通用权益则不需要指定规则，如没有规则，即认为全部会员生效。
        /// </summary>
        [XmlElement("benefit_rule")]
        public string BenefitRule { get; set; }

        /// <summary>
        /// 权益类型，STATIC_PRIVILEGE -静态权益，DYNAMIC_PRIVILEGE - 动态权益
        /// </summary>
        [XmlElement("benefit_type")]
        public string BenefitType { get; set; }

        /// <summary>
        /// 权益描述信息，如有权益需要填写描述信息，需要确保所有的权益都具备描述信息，否则都不填写描述。
        /// </summary>
        [XmlArray("desc")]
        [XmlArrayItem("string")]
        public List<string> Desc { get; set; }

        /// <summary>
        /// 特权logo图标地址，需要通过alipay.offline.material.image.upload 上传。 特权的logo图片大小为56x56像素。
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 外部权益id，由商家自行指定，需要确保在该商家权益内能保证区分出唯一权益内容。在内券权益中，该值传内券活动ID（activityId）
        /// </summary>
        [XmlElement("out_benefit_id")]
        public string OutBenefitId { get; set; }

        /// <summary>
        /// 权益的优先级，需要指定在1-20之间，优先级的值越小，权益展示约靠前
        /// </summary>
        [XmlElement("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// ENABLE("已生效"), DISABLE("未生效");
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 权益的副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 权益标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 权益的跳转地址，卡面点击可跳转到商家小程序地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
