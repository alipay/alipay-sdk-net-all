using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGroupshoppingBenefitQueryResponse.
    /// </summary>
    public class AlipayUserGroupshoppingBenefitQueryResponse : AopResponse
    {
        /// <summary>
        /// 拼团支付宝权益透出金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 该用户是否有权益
        /// </summary>
        [XmlElement("have_benefit")]
        public bool HaveBenefit { get; set; }

        /// <summary>
        /// 查询权益的图标地址
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 查询权益的跳转地址
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 发放权益原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 查询权益的副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 查询权益的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
