using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAivisionstoredAiretaileventSyncResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAivisionstoredAiretaileventSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回数据信息
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
