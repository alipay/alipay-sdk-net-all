using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterVerifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpassporterVerifyQueryModel : AopObject
    {
        /// <summary>
        /// mac地址
        /// </summary>
        [XmlElement("mac_address")]
        public string MacAddress { get; set; }

        /// <summary>
        /// 默认10分钟，查询最近10分钟内是否有核身成功记录
        /// </summary>
        [XmlElement("minutes_ago")]
        public long MinutesAgo { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 活动单号
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
