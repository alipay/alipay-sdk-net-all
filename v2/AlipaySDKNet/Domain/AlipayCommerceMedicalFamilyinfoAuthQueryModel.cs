using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalFamilyinfoAuthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalFamilyinfoAuthQueryModel : AopObject
    {
        /// <summary>
        /// 通过亲情账户我的家人信息插件地址接口或其他方式获取到的有效访问令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }
    }
}
