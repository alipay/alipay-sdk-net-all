using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunCallcontainerSessionApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunCallcontainerSessionApplyModel : AopObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("custom_id")]
        public string CustomId { get; set; }

        /// <summary>
        /// 环境ID，指的是小程序云环境的ID，包含云开发、云托管环境
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 宿主AppId，非插件业务可以传递小程序AppId
        /// </summary>
        [XmlElement("parent_app_id")]
        public string ParentAppId { get; set; }

        /// <summary>
        /// 指定env对应的AppId 可空
        /// </summary>
        [XmlElement("sp_app_id")]
        public string SpAppId { get; set; }
    }
}
