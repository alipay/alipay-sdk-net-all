using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOpenbizmocktoolsQueryResponse.
    /// </summary>
    public class AlipayOpenOpenbizmocktoolsQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询GroupID关系得到的结果
        /// </summary>
        [XmlElement("app_group_ext")]
        public AppGroupExt AppGroupExt { get; set; }

        /// <summary>
        /// 应用密钥配置
        /// </summary>
        [XmlArray("app_security_ext")]
        [XmlArrayItem("app_security_ext")]
        public List<AppSecurityExt> AppSecurityExt { get; set; }

        /// <summary>
        /// AES密钥配置
        /// </summary>
        [XmlArray("encrypt_config_ext")]
        [XmlArrayItem("encrypt_config_ext")]
        public List<EncryptConfigExt> EncryptConfigExt { get; set; }

        /// <summary>
        /// 接口配置
        /// </summary>
        [XmlElement("exterface_ext")]
        public ExterfaceExt ExterfaceExt { get; set; }

        /// <summary>
        /// 查询openid的灰度配置
        /// </summary>
        [XmlElement("open_id_config_request_ext")]
        public OpenIdConfigRequestExt OpenIdConfigRequestExt { get; set; }

        /// <summary>
        /// 压测私钥
        /// </summary>
        [XmlElement("private_key")]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 应用的配置信息
        /// </summary>
        [XmlElement("query_app_info_ext")]
        public QueryAppInfoExt QueryAppInfoExt { get; set; }

        /// <summary>
        /// 密钥配置
        /// </summary>
        [XmlArray("security_profile_ext")]
        [XmlArrayItem("security_profile_ext")]
        public List<SecurityProfileExt> SecurityProfileExt { get; set; }

        /// <summary>
        /// SPI接口配置
        /// </summary>
        [XmlElement("spi_config")]
        public string SpiConfig { get; set; }
    }
}
