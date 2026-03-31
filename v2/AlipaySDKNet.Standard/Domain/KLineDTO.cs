using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KLineDTO Data Structure.
    /// </summary>
    [Serializable]
    public class KLineDTO : AopObject
    {
        /// <summary>
        /// 成交额，单元为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 收盘价，单元为元
        /// </summary>
        [XmlElement("close_price")]
        public string ClosePrice { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 最高价，单元为元
        /// </summary>
        [XmlElement("high_price")]
        public string HighPrice { get; set; }

        /// <summary>
        /// 最低价，单元为元
        /// </summary>
        [XmlElement("low_price")]
        public string LowPrice { get; set; }

        /// <summary>
        /// 开盘价，单元为元
        /// </summary>
        [XmlElement("open_price")]
        public string OpenPrice { get; set; }

        /// <summary>
        /// 前收价，单元为元
        /// </summary>
        [XmlElement("previous_price")]
        public string PreviousPrice { get; set; }

        /// <summary>
        /// 成交量，单元为股数
        /// </summary>
        [XmlElement("volume")]
        public string Volume { get; set; }
    }
}
