using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupUserVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupUserVO : AopObject
    {
        /// <summary>
        /// 身份证后4位，后台会进行校验。
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户openid，2088开头的16位数字。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户user_id，2088开头的16位数字。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称（花名 or  昵称），后台会校验是否是真实姓名。
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
