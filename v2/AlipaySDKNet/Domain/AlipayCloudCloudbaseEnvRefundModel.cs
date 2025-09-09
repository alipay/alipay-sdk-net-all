using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseEnvRefundModel : AopObject
    {
        /// <summary>
        /// 小程序云应用APPID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 小程序云应用ENVID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }
    }
}
