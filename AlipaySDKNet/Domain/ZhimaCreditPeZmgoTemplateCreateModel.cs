using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoTemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoTemplateCreateModel : AopObject
    {
        /// <summary>
        /// 使用权益跳转链接
        /// </summary>
        [XmlElement("benefit_url")]
        public string BenefitUrl { get; set; }

        /// <summary>
        /// 业务号，控制幂等
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 模板适用的商家pid列表，不传默认为商户id
        /// </summary>
        [XmlArray("consume_pid_list")]
        [XmlArrayItem("string")]
        public List<string> ConsumePidList { get; set; }

        /// <summary>
        /// 商家联系方式
        /// </summary>
        [XmlElement("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 扩展内容，主要满足文案和展示类、个性化定制需求
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 会员协议html文本
        /// </summary>
        [XmlElement("member_agreement")]
        public string MemberAgreement { get; set; }

        /// <summary>
        /// 会员模式。 PAID_MEMBER，付费会员； PROMISE_MEMBER，承诺会员。
        /// </summary>
        [XmlElement("member_mode")]
        public string MemberMode { get; set; }

        /// <summary>
        /// 会员规则
        /// </summary>
        [XmlElement("member_rule")]
        public MemberRule MemberRule { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
