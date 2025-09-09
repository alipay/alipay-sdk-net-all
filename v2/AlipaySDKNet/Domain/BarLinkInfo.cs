using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BarLinkInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BarLinkInfo : AopObject
    {
        /// <summary>
        /// LOCKER_SUCCESS - 开锁成功，LOCKER_FAIL-开锁失败； CHECK_FAIL-强制检查失败
        /// </summary>
        [XmlElement("action_code")]
        public string ActionCode { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 导航图标图片url
        /// </summary>
        [XmlElement("log_url")]
        public string LogUrl { get; set; }
    }
}
