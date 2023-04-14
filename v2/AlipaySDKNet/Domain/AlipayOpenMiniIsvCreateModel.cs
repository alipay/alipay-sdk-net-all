using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniIsvCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniIsvCreateModel : AopObject
    {
        /// <summary>
        /// 小程序代创建请求
        /// </summary>
        [XmlElement("create_mini_request")]
        public CreateMiniRequest CreateMiniRequest { get; set; }
    }
}
