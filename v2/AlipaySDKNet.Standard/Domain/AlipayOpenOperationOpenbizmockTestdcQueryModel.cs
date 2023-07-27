using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestdcQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTestdcQueryModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a_open_id")]
        public string AOpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a_uid")]
        public string AUid { get; set; }

        /// <summary>
        /// lalala
        /// </summary>
        [XmlArray("aa")]
        [XmlArrayItem("string")]
        public List<string> Aa { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("aaaaa")]
        public string Aaaaa { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("aaaaa_open_id")]
        public string AaaaaOpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ab")]
        public string Ab { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ac")]
        public string Ac { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ad")]
        public long Ad { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ae")]
        public bool Ae { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("c")]
        public string C { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("d")]
        public string D { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(1234567891011121314151617182)
        /// </summary>
        [XmlElement("e")]
        public bool E { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(111111111111)
        /// </summary>
        [XmlElement("g")]
        public AAAAAtest G { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("i")]
        [XmlArrayItem("string")]
        public List<string> I { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("mn")]
        public AAAAAtest Mn { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss")]
        public string Sss { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("uid_2_open_id")]
        public string Uid2OpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("uid_open_id")]
        public string UidOpenId { get; set; }
    }
}
