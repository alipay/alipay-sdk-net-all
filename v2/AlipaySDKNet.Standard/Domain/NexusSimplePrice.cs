using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NexusSimplePrice Data Structure.
    /// </summary>
    [Serializable]
    public class NexusSimplePrice : AopObject
    {
        /// <summary>
        /// 是否可用
        /// </summary>
        [XmlElement("active")]
        public bool Active { get; set; }

        /// <summary>
        /// 价格id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 价格信息元数据
        /// </summary>
        [XmlElement("metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// 订阅周期信息
        /// </summary>
        [XmlElement("recurring")]
        public Recurring Recurring { get; set; }

        /// <summary>
        /// 价格类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 单位金额，单位：分
        /// </summary>
        [XmlElement("unit_amount")]
        public long UnitAmount { get; set; }
    }
}
