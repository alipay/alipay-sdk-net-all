using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterInclusioneventdataCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpassporterInclusioneventdataCreateModel : AopObject
    {
        /// <summary>
        /// 注册和开闸场景传项目ID，如：HD20250730000001XKK999，其他论坛签到场景传论坛各自论坛活动ID即可
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 业务类型 开闸机注册:REGISTER 开闸机:OPEN_GATE 分会场签到:SIGN_IN
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 用户标签
        /// </summary>
        [XmlElement("user_tag")]
        public string UserTag { get; set; }
    }
}
