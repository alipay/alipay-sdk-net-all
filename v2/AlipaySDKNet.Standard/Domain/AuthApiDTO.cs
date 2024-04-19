using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AuthApiDTO : AopObject
    {
        /// <summary>
        /// 敏感信息可申请接口名
        /// </summary>
        [XmlElement("api_name")]
        public string ApiName { get; set; }

        /// <summary>
        /// 敏感信息申请字段
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 敏感信息申请能力code值
        /// </summary>
        [XmlElement("package_code")]
        public string PackageCode { get; set; }
    }
}
