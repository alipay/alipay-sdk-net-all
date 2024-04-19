using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncWallstreetCompareflowTransferResponse.
    /// </summary>
    public class AlipayBossFncWallstreetCompareflowTransferResponse : AopResponse
    {
        /// <summary>
        /// 转发成功与否
        /// </summary>
        [XmlElement("system_success")]
        public string SystemSuccess { get; set; }
    }
}
