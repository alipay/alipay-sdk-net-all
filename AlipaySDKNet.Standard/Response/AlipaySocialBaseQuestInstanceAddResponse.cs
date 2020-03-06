using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceAddResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceAddResponse : AopResponse
    {
        /// <summary>
        /// 小目标实例模型
        /// </summary>
        [XmlElement("instance")]
        public QuestInstanceDO Instance { get; set; }
    }
}
