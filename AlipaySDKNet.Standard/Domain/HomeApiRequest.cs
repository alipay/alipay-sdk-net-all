using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HomeApiRequest Data Structure.
    /// </summary>
    [Serializable]
    public class HomeApiRequest : AopObject
    {
        /// <summary>
        /// 业务的类型
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务唯一id，比如包裹id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 展示的内容
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("home_api_content")]
        public List<HomeApiContent> Content { get; set; }

        /// <summary>
        /// 节点状态
        /// </summary>
        [XmlElement("node_code")]
        public string NodeCode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
