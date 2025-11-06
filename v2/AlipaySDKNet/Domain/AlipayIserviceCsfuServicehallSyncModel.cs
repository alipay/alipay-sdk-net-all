using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCsfuServicehallSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCsfuServicehallSyncModel : AopObject
    {
        /// <summary>
        /// 保持和原接口兼容 使用string类型, 参考:com.alipay.antmcc.facade.model.aiworker.ChatRequest
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
