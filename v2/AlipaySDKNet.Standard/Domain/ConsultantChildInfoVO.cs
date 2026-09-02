using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultantChildInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultantChildInfoVO : AopObject
    {
        /// <summary>
        /// 出生日期，格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("birth_date")]
        public string BirthDate { get; set; }

        /// <summary>
        /// 性别：男/女
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 联系手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 成员档案ID
        /// </summary>
        [XmlElement("profile_id")]
        public string ProfileId { get; set; }

        /// <summary>
        /// 儿童姓名
        /// </summary>
        [XmlElement("profile_name")]
        public string ProfileName { get; set; }
    }
}
