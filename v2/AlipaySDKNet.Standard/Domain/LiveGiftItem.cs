using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LiveGiftItem Data Structure.
    /// </summary>
    [Serializable]
    public class LiveGiftItem : AopObject
    {
        /// <summary>
        /// 礼物图标
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 礼物ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 礼物名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 礼物价格，单位宝石
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 礼物类型，免费、付费
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
