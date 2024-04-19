using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestparameterQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTestparameterQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("appid_one")]
        public string AppidOne { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("appid_out_one")]
        public string AppidOutOne { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("appid_out_two")]
        public string AppidOutTwo { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("appid_two")]
        public string AppidTwo { get; set; }

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
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("e")]
        public bool E { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("f")]
        public string F { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("number")]
        public long Number { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("one_uid")]
        public string OneUid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("one_uid_openid")]
        public string OneUidOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlArray("ss_list")]
        [XmlArrayItem("string")]
        public List<string> SsList { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test")]
        public OpenidComplex Test { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("test_test")]
        public OpenidComplex TestTest { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("two_uid")]
        public string TwoUid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("two_uid_openid")]
        public string TwoUidOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("uid_one")]
        public string UidOne { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("uid_two")]
        public string UidTwo { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("uidone_openid")]
        public string UidoneOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("uidtwo_openid")]
        public string UidtwoOpenid { get; set; }
    }
}
