using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseFunctionModifyModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境ID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 云函数信息描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 云函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 运行环境  - nodejs12  - nodejs18  - python39  - php74  - java17
        /// </summary>
        [XmlElement("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// 规格配置  - 0.25c0.5g  - 0.5c1g  - 1c2g
        /// </summary>
        [XmlElement("quota_name")]
        public string QuotaName { get; set; }
    }
}
