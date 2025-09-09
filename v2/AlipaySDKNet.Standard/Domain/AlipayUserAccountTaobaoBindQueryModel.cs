using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountTaobaoBindQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountTaobaoBindQueryModel : AopObject
    {
        /// <summary>
        /// 淘宝havanaId
        /// </summary>
        [XmlElement("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 安全SDK生成的设备指纹
        /// </summary>
        [XmlElement("umid")]
        public string Umid { get; set; }

        /// <summary>
        /// 为核身后支付宝生成的授权用户信息token，用来获取要绑定的支付宝账号信息
        /// </summary>
        [XmlElement("user_token")]
        public string UserToken { get; set; }
    }
}
