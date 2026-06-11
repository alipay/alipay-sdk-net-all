using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneMarketingBlackcarduserUserinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneMarketingBlackcarduserUserinfoQueryModel : AopObject
    {
        /// <summary>
        /// 用户证件号，AES加密
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 查询权益类型
        /// </summary>
        [XmlElement("equity_code")]
        public string EquityCode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 查询场景类型
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名，AES加密
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
