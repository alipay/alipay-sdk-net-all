using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvRefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseEnvRefundQueryModel : AopObject
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
