using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdJhjtestPredocCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdJhjtestPredocCancelModel : AopObject
    {
        /// <summary>
        /// 11111
        /// </summary>
        [XmlElement("com_a")]
        public JhjtestDoc ComA { get; set; }

        /// <summary>
        /// 添加不在迭代内的开发中2.0复杂类型，
        /// </summary>
        [XmlElement("com_c")]
        public JhjTestNew ComC { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("is_s")]
        public string IsS { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("isasdasd")]
        public bool Isasdasd { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("price_a_input")]
        public string PriceAInput { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sdd")]
        public bool Sdd { get; set; }

        /// <summary>
        /// 基础描述修改缓存11
        /// </summary>
        [XmlElement("test_a")]
        public string TestA { get; set; }

        /// <summary>
        /// 基础描述修改缓存11
        /// </summary>
        [XmlElement("test_a_openid")]
        public string TestAOpenid { get; set; }
    }
}
