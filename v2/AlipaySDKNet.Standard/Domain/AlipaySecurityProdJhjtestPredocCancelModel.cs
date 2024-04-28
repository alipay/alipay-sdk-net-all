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
        /// 基础描述修改缓存11 当前字段已废弃(废弃了)
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
