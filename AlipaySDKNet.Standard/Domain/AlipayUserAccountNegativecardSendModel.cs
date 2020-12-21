using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountNegativecardSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountNegativecardSendModel : AopObject
    {
        /// <summary>
        /// 模板参数,键值对，以竖线分割
        /// </summary>
        [XmlElement("arguments")]
        public string Arguments { get; set; }

        /// <summary>
        /// 扩展信息。
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 负一屏卡片业务码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
