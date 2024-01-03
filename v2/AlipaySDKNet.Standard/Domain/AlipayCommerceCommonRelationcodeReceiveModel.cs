using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonRelationcodeReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonRelationcodeReceiveModel : AopObject
    {
        /// <summary>
        /// alipay开头的scheme，团长机构设定的支心客关系绑定页面
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
