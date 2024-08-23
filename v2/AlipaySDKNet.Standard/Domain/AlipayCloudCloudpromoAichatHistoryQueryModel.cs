using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatHistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAichatHistoryQueryModel : AopObject
    {
        /// <summary>
        /// 用户的ID
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 每页拉取数量，[1,10]范围，单位为int，个
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 第几页，从1开始，页码的单位为int，从1开始
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 智能问答服务场景ID
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 原始请求真实的APPID
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
