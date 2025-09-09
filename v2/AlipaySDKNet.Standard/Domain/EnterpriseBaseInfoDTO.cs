using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseBaseInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseBaseInfoDTO : AopObject
    {
        /// <summary>
        /// 企业注册页面需要回显的企业简称
        /// </summary>
        [XmlElement("enterprise_alias")]
        public string EnterpriseAlias { get; set; }

        /// <summary>
        /// 企业注册页面需要回显的统一社会信用代码，只能是数字和字母组成
        /// </summary>
        [XmlElement("enterprise_code")]
        public string EnterpriseCode { get; set; }

        /// <summary>
        /// 企业注册页面需要回显的企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 企业注册页面需要回显的企业所属行业
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }
    }
}
