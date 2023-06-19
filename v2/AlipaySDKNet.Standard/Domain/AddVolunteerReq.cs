using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AddVolunteerReq Data Structure.
    /// </summary>
    [Serializable]
    public class AddVolunteerReq : AopObject
    {
        /// <summary>
        /// 生态合作伙伴
        /// </summary>
        [XmlElement("agency")]
        public string Agency { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 志愿者电话号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 身份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 人员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 志愿者姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
