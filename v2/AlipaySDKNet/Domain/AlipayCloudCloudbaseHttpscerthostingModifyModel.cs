using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpscerthostingModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseHttpscerthostingModifyModel : AopObject
    {
        /// <summary>
        /// 小程序云APPID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 小程序云ENVID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 证书托管是否开启
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 对外唯一标识
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
