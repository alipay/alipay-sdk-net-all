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
        /// 每页拉取数量，[1,10]范围
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 第几页，从1开始
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 智能问答服务场景ID
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
