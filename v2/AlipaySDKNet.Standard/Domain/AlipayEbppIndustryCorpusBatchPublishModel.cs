using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCorpusBatchPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCorpusBatchPublishModel : AopObject
    {
        /// <summary>
        /// 政务智能体id。在政务AI（光华）开放平台配置云端私有化版本智能体后可以获取该参数信息
        /// </summary>
        [XmlElement("bot_id")]
        public string BotId { get; set; }

        /// <summary>
        /// 知识语料类型
        /// </summary>
        [XmlElement("corpus_type")]
        public string CorpusType { get; set; }

        /// <summary>
        /// 用于传递哪些语料需要上线或下线操作。根据不同的corpus_type传递对应的语料列表
        /// </summary>
        [XmlArray("out_corpus_id_list")]
        [XmlArrayItem("string")]
        public List<string> OutCorpusIdList { get; set; }

        /// <summary>
        /// 用于说明发布任务信息，需要注明是哪种语料，上线还是下线，尽量描述的清晰准确
        /// </summary>
        [XmlElement("publish_name")]
        public string PublishName { get; set; }

        /// <summary>
        /// 知识发布类型
        /// </summary>
        [XmlElement("publish_type")]
        public string PublishType { get; set; }
    }
}
