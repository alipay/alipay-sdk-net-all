using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbasePersonalIdentityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbasePersonalIdentityCreateModel : AopObject
    {
        /// <summary>
        /// 实人认证姓名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 使用国密4加密后的身份证号
        /// </summary>
        [XmlElement("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// oceanbase官网登录后唯一标识
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
