using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RightNoOpenedList Data Structure.
    /// </summary>
    [Serializable]
    public class RightNoOpenedList : AopObject
    {
        /// <summary>
        /// 赠险标志
        /// </summary>
        [XmlElement("gift_prod_code")]
        public string GiftProdCode { get; set; }

        /// <summary>
        /// 是否开通
        /// </summary>
        [XmlElement("opened")]
        public bool Opened { get; set; }

        /// <summary>
        /// 赠险产品码
        /// </summary>
        [XmlElement("right_no")]
        public string RightNo { get; set; }
    }
}
