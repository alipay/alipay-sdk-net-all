using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayGongyiUserInfoTest Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayGongyiUserInfoTest : AopObject
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        [XmlElement("address")]
        public AlipayGongyiAddressTest Address { get; set; }

        /// <summary>
        /// 10
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 1912-12-12
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 上海，杭州
        /// </summary>
        [XmlArray("citys")]
        [XmlArrayItem("string")]
        public List<string> Citys { get; set; }

        /// <summary>
        /// 1001
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// zhangsan
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 学校地址列表
        /// </summary>
        [XmlArray("school_list")]
        [XmlArrayItem("alipay_gongyi_address_test")]
        public List<AlipayGongyiAddressTest> SchoolList { get; set; }
    }
}
