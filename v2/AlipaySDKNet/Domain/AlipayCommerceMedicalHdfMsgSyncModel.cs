using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfMsgSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfMsgSyncModel : AopObject
    {
        /// <summary>
        /// 平台的appid
        /// </summary>
        [XmlElement("msg_app_id")]
        public string MsgAppId { get; set; }

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
