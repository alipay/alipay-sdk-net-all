using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftBatchInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GiftBatchInfo : AopObject
    {
        /// <summary>
        /// 成组列表
        /// </summary>
        [XmlArray("batch_list")]
        [XmlArrayItem("batch_list")]
        public List<BatchList> BatchList { get; set; }

        /// <summary>
        /// 成组子标题
        /// </summary>
        [XmlElement("batch_sub_title")]
        public string BatchSubTitle { get; set; }

        /// <summary>
        /// 用于定义具体礼物
        /// </summary>
        [XmlElement("gift_id")]
        public string GiftId { get; set; }
    }
}
