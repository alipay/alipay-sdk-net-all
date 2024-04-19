using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseExtensionFeeGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseExtensionFeeGetModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 查询产品  - REDIS  - MYSQL
        /// </summary>
        [XmlElement("product")]
        public string Product { get; set; }
    }
}
