using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCardUserinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCardUserinfoQueryModel : AopObject
    {
        /// <summary>
        /// 通过亲情账户绑定关系插件地址接口或其他方式获取到的有效访问令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }
    }
}
