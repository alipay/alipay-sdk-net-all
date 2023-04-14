using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApeSelect Data Structure.
    /// </summary>
    [Serializable]
    public class ApeSelect : AopObject
    {
        /// <summary>
        /// 物品的唯一id（允许存在英文）
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 选品池id
        /// </summary>
        [XmlElement("select_id")]
        public string SelectId { get; set; }

        /// <summary>
        /// 只允许0或者1。0代表不可用，1代表可用。
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
