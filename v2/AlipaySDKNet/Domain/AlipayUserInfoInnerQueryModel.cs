using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserInfoInnerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserInfoInnerQueryModel : AopObject
    {
        /// <summary>
        /// 阿里集团统一ID
        /// </summary>
        [XmlElement("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 登录ID
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝号，由字母和数字组成的字符串
        /// </summary>
        [XmlElement("zid")]
        public string Zid { get; set; }
    }
}
