using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsportalLogincontextQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsportalLogincontextQueryModel : AopObject
    {
        /// <summary>
        /// 令牌
        /// </summary>
        [XmlElement("login_token")]
        public string LoginToken { get; set; }
    }
}
