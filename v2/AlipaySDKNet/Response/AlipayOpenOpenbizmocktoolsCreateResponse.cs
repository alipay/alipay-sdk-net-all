using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOpenbizmocktoolsCreateResponse.
    /// </summary>
    public class AlipayOpenOpenbizmocktoolsCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建应用的APPID
        /// </summary>
        [XmlElement("app_number")]
        public string AppNumber { get; set; }

        /// <summary>
        /// 授权令牌
        /// </summary>
        [XmlElement("auth_token")]
        public string AuthToken { get; set; }

        /// <summary>
        /// group_id值
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// OPENID值
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 功能包编码
        /// </summary>
        [XmlElement("package_code")]
        public string PackageCode { get; set; }

        /// <summary>
        /// SPI接口的配置
        /// </summary>
        [XmlElement("spi_config")]
        public string SpiConfig { get; set; }

        /// <summary>
        /// UID值
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// union_id值
        /// </summary>
        [XmlElement("union_id")]
        public string UnionId { get; set; }
    }
}
