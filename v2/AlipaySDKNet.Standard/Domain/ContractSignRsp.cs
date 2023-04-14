using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractSignRsp Data Structure.
    /// </summary>
    [Serializable]
    public class ContractSignRsp : AopObject
    {
        /// <summary>
        /// 用户id映射openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 签署地址
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
