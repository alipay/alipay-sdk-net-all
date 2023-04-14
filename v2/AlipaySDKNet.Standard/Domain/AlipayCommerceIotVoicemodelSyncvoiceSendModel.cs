using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotVoicemodelSyncvoiceSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotVoicemodelSyncvoiceSendModel : AopObject
    {
        /// <summary>
        /// 服务调用上下文
        /// </summary>
        [XmlElement("context")]
        public ServiceModelContext Context { get; set; }

        /// <summary>
        /// 到账播报内容模型
        /// </summary>
        [XmlElement("sync_data")]
        public SyncVoiceVO SyncData { get; set; }
    }
}
