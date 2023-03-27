using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppinfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppinfoModifyModel : AopObject
    {
        /// <summary>
        /// 应用openid配置
        /// </summary>
        [XmlElement("open_id_config")]
        public string OpenIdConfig { get; set; }
    }
}
