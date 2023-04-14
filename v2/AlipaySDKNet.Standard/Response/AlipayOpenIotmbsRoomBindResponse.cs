using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotmbsRoomBindResponse.
    /// </summary>
    public class AlipayOpenIotmbsRoomBindResponse : AopResponse
    {
        /// <summary>
        /// 成功为true，失败为false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
