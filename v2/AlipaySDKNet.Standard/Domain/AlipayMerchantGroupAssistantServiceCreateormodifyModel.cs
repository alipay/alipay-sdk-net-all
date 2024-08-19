using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupAssistantServiceCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupAssistantServiceCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 小助手内容id，创建快捷服务时返回的数据唯一id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 群组id列表，创建群组时对应的一个群组id
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 小助手快捷服务名称，b侧展示用，不在c侧群内透出
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务列表
        /// </summary>
        [XmlArray("services")]
        [XmlArrayItem("assistant_service_v_o")]
        public List<AssistantServiceVO> Services { get; set; }
    }
}
