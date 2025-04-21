using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersalesInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AftersalesInfo : AopObject
    {
        /// <summary>
        /// 售后单编号
        /// </summary>
        [XmlElement("aftersales_id")]
        public string AftersalesId { get; set; }

        /// <summary>
        /// 售后单状态
        /// </summary>
        [XmlElement("aftersales_status")]
        public string AftersalesStatus { get; set; }

        /// <summary>
        /// 卡编号
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 售后发起时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 用户发起售后的描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("proofs")]
        [XmlArrayItem("string")]
        public List<string> Proofs { get; set; }

        /// <summary>
        /// 售后发起原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
