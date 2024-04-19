using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthAuthenticationpluginQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthAuthenticationpluginQueryModel : AopObject
    {
        /// <summary>
        /// 通过受理台签约接口获取到的signStr
        /// </summary>
        [XmlElement("sign_str")]
        public string SignStr { get; set; }
    }
}
