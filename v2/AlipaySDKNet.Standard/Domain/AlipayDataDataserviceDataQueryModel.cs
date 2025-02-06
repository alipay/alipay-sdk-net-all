using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceDataQueryModel : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 车钥匙数量
        /// </summary>
        [XmlElement("car_keys")]
        public long CarKeys { get; set; }

        /// <summary>
        /// {"key":"value"};
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// helle
        /// </summary>
        [XmlElement("hello_hq")]
        public HelloHq HelloHq { get; set; }

        /// <summary>
        /// 3
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 座位数
        /// </summary>
        [XmlElement("seats")]
        public string Seats { get; set; }

        /// <summary>
        /// 注意事项
        /// </summary>
        [XmlArray("test_g_one")]
        [XmlArrayItem("string")]
        public List<string> TestGOne { get; set; }

        /// <summary>
        /// 总额
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }
    }
}
