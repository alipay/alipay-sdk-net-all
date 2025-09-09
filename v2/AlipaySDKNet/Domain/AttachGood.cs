using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttachGood Data Structure.
    /// </summary>
    [Serializable]
    public class AttachGood : AopObject
    {
        /// <summary>
        /// 加料id
        /// </summary>
        [XmlElement("attach_good_id")]
        public string AttachGoodId { get; set; }

        /// <summary>
        /// 加料名
        /// </summary>
        [XmlElement("attach_good_name")]
        public string AttachGoodName { get; set; }

        /// <summary>
        /// 12元
        /// </summary>
        [XmlElement("attach_good_price")]
        public long AttachGoodPrice { get; set; }

        /// <summary>
        /// 1个
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }
    }
}
