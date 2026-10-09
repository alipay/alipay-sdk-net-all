using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCorpusBatchSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCorpusBatchSyncModel : AopObject
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
        /// 政策文件列表
        /// </summary>
        [XmlArray("doc_list")]
        [XmlArrayItem("doc_d_t_o")]
        public List<DocDTO> DocList { get; set; }

        /// <summary>
        /// FAQ问答列表参数
        /// </summary>
        [XmlArray("faq_list")]
        [XmlArrayItem("common_qa_d_t_o")]
        public List<CommonQaDTO> FaqList { get; set; }

        /// <summary>
        /// 办事事项列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("service_item_d_t_o")]
        public List<ServiceItemDTO> ItemList { get; set; }

        /// <summary>
        /// 服务信息
        /// </summary>
        [XmlArray("service_list")]
        [XmlArrayItem("gov_org_service_d_t_o")]
        public List<GovOrgServiceDTO> ServiceList { get; set; }
    }
}
