using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseBsnAssignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseBsnAssignModel : AopObject
    {
        /// <summary>
        /// 阿里云账号ID
        /// </summary>
        [XmlElement("aliuid")]
        public string Aliuid { get; set; }

        /// <summary>
        /// 小程序云应用APPID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 小程序云环境ID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 备案服务码
        /// </summary>
        [XmlElement("bsn")]
        public string Bsn { get; set; }
    }
}
