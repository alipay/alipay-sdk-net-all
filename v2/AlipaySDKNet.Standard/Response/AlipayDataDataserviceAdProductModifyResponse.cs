using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdProductModifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdProductModifyResponse : AopResponse
    {
        /// <summary>
        /// 是否更新成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
