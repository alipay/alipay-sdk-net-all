using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderUserinfoExpoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderUserinfoExpoCreateModel : AopObject
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 身份证号。可以传明文，也可以传身份证号的32位大写MD5值。尽量使用MD5值
        /// </summary>
        [XmlElement("identity_card")]
        public string IdentityCard { get; set; }

        /// <summary>
        /// 公司职务
        /// </summary>
        [XmlElement("meeting_role")]
        public string MeetingRole { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 多个参数录入可选，tag_code和tag_name至多传一个
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 多个参数录入可选，tag_code和tag_name至多传一个
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 活动最小单元ID
        /// </summary>
        [XmlElement("time_uuid")]
        public string TimeUuid { get; set; }
    }
}
