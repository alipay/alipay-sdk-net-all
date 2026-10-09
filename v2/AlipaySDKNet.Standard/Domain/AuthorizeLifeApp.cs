using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthorizeLifeApp Data Structure.
    /// </summary>
    [Serializable]
    public class AuthorizeLifeApp : AopObject
    {
        /// <summary>
        /// 在支付宝平台注册的生活号应用对应的应用id
        /// </summary>
        [XmlElement("life_app_id")]
        public string LifeAppId { get; set; }

        /// <summary>
        /// 支付宝平台创建的生活号应用名称，用于授权影视作品
        /// </summary>
        [XmlElement("life_app_name")]
        public string LifeAppName { get; set; }
    }
}
