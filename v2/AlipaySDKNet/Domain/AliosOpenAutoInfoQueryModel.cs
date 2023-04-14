using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AliosOpenAutoInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AliosOpenAutoInfoQueryModel : AopObject
    {
        /// <summary>
        /// 设备token
        /// </summary>
        [XmlElement("device_token")]
        public string DeviceToken { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
