using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SolutionAttributeInfoOpenVO Data Structure.
    /// </summary>
    [Serializable]
    public class SolutionAttributeInfoOpenVO : AopObject
    {
        /// <summary>
        /// 至少用户需要选择一个方式进行签约。
        /// </summary>
        [XmlElement("access_config_code")]
        public string AccessConfigCode { get; set; }

        /// <summary>
        /// 主要端外只能使用端外短信验证码的模式，其它两种只能端内小程序使用。
        /// </summary>
        [XmlElement("verify_code")]
        public string VerifyCode { get; set; }
    }
}
