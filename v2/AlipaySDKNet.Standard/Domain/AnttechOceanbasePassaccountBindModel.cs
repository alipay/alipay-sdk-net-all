using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbasePassaccountBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbasePassaccountBindModel : AopObject
    {
        /// <summary>
        /// 邮箱 取值为加密后的邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 手机号 取值为加密后的手机号码
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 用户通行证id，为OB注册账号id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
