using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotContentSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotContentSyncModel : AopObject
    {
        /// <summary>
        /// 同步内容列表，格式取决于同步数据的场景
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("string")]
        public List<string> ContentList { get; set; }

        /// <summary>
        /// 请求ID，标识唯一一次请求，串联调用方的内部链路
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景码，用于指定当前同步数据所属的业务场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
