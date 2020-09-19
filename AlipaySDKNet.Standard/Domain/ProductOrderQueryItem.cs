using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductOrderQueryItem Data Structure.
    /// </summary>
    [Serializable]
    public class ProductOrderQueryItem : AopObject
    {
        /// <summary>
        /// 订购渠道
        /// </summary>
        [XmlElement("ordered_channel")]
        public string OrderedChannel { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("ps_code")]
        public string PsCode { get; set; }
    }
}
