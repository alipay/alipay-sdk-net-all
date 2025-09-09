using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateMultideductQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateMultideductQueryModel : AopObject
    {
        /// <summary>
        /// 业务码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 学校（或教育机构）内标。支付宝提供的学校编号，如果您不知道学校编号，可以联系您的BD咨询获取
        /// </summary>
        [XmlElement("school_code")]
        public string SchoolCode { get; set; }

        /// <summary>
        /// 校园支付token。优先使用「学校或教育机构内标」和「支付宝openid」或「学生或教职工的支付宝uid」，前两者都为空时使用当前参数。需要注意的是，三个参数不能同时为空，且token为空时另两个参数不能为空。
        /// </summary>
        [XmlElement("token_id")]
        public string TokenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
