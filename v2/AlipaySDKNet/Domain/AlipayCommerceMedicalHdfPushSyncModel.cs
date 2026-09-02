using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfPushSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfPushSyncModel : AopObject
    {
        /// <summary>
        /// PUSH消息控制
        /// </summary>
        [XmlElement("health_msg_class")]
        public string HealthMsgClass { get; set; }

        /// <summary>
        /// PUSH平台的appid
        /// </summary>
        [XmlElement("push_app_id")]
        public string PushAppId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("receiver_ids")]
        [XmlArrayItem("string")]
        public List<string> ReceiverIds { get; set; }

        /// <summary>
        /// 模版参数
        /// </summary>
        [XmlElement("template_args")]
        public string TemplateArgs { get; set; }

        /// <summary>
        /// PUSH模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
