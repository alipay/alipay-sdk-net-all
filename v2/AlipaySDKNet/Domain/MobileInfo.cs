using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MobileInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MobileInfo : AopObject
    {
        /// <summary>
        /// 运营商代码
        /// </summary>
        [XmlElement("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// 归属省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 子运营商名称
        /// </summary>
        [XmlElement("sub_operator")]
        public string SubOperator { get; set; }
    }
}
