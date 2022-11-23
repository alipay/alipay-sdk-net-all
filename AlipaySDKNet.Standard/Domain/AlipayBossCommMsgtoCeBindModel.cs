using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossCommMsgtoCeBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossCommMsgtoCeBindModel : AopObject
    {
        /// <summary>
        /// 特殊可选，Date类型
        /// </summary>
        [XmlElement("business_scope")]
        public string BusinessScope { get; set; }

        /// <summary>
        /// ,必选，复杂类型
        /// </summary>
        [XmlElement("cert_no")]
        public ActivityGoods CertNo { get; set; }

        /// <summary>
        /// ,boolean，可选 示例值false
        /// </summary>
        [XmlElement("hascode")]
        public bool Hascode { get; set; }

        /// <summary>
        /// number类型，必选
        /// </summary>
        [XmlElement("mobile")]
        public long Mobile { get; set; }

        /// <summary>
        /// 省份,必选，具体类型string，安全等级R0，
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 特殊可选，price类型
        /// </summary>
        [XmlArray("user_name")]
        [XmlArrayItem("price")]
        public List<string> UserName { get; set; }
    }
}
