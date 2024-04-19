using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MaterialResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MaterialResultInfo : AopObject
    {
        /// <summary>
        /// 测试物品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 结果url
        /// </summary>
        [XmlElement("result_img")]
        public string ResultImg { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
