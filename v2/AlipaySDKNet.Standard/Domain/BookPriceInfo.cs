using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BookPriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BookPriceInfo : AopObject
    {
        /// <summary>
        /// 书籍原价。单位元，最多两位小数。收费书籍必填
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 销售方式：BOOK（整本售卖）、SINGLE_SINGLE_CHAPTER（单个章节售卖） 收费书籍必填
        /// </summary>
        [XmlElement("sell_type")]
        public string SellType { get; set; }
    }
}
