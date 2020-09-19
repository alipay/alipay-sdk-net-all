using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthSignApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMobileauthSignApplyModel : AopObject
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [XmlElement("request")]
        public string Request { get; set; }
    }
}
