using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePeriodcardIndirectconfigCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePeriodcardIndirectconfigCreateModel : AopObject
    {
        /// <summary>
        /// 群组code
        /// </summary>
        [XmlElement("group_code")]
        public string GroupCode { get; set; }

        /// <summary>
        /// 群组信用服务id
        /// </summary>
        [XmlElement("group_zm_service_id")]
        public string GroupZmServiceId { get; set; }

        /// <summary>
        /// 接口消息通知appid
        /// </summary>
        [XmlElement("notify_app_id")]
        public string NotifyAppId { get; set; }

        /// <summary>
        /// 机构pid
        /// </summary>
        [XmlElement("org_pid")]
        public string OrgPid { get; set; }

        /// <summary>
        /// 扣款场景码
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }
    }
}
