using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaDataCreditscoreExemplifiedCoderainyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaDataCreditscoreExemplifiedCoderainyQueryModel : AopObject
    {
        /// <summary>
        /// 基础类型-Boolean
        /// </summary>
        [XmlElement("boolean_a")]
        public bool BooleanA { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 简单描述
        /// </summary>
        [XmlElement("string_a")]
        public string StringA { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("testcase_openid")]
        public string TestcaseOpenid { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
