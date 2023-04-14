using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskMsgtoMsgFreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskMsgtoMsgFreezeModel : AopObject
    {
        /// <summary>
        /// 基础类型，string类型，必选，有枚举值json格式：[{"value": "枚举值1","name": "枚举名1"},{"value": "枚举值2","name": "枚举名2"}]
        /// </summary>
        [XmlElement("c_ka")]
        public string CKa { get; set; }

        /// <summary>
        /// 证件号,可选，有映射值,示例值[true,false,true]
        /// </summary>
        [XmlArray("cert_no")]
        [XmlArrayItem("boolean")]
        public List<bool> CertNo { get; set; }

        /// <summary>
        /// 市，可选，复杂类型
        /// </summary>
        [XmlElement("city_code")]
        public JinyouTestFour CityCode { get; set; }

        /// <summary>
        /// 营业执照有效期，特殊可选，具体类型boolean
        /// </summary>
        [XmlElement("license_expiry_date")]
        public bool LicenseExpiryDate { get; set; }

        /// <summary>
        /// 基础类型，必选，有映射
        /// </summary>
        [XmlElement("x_dd")]
        public string XDd { get; set; }

        /// <summary>
        /// 基础类型，必选，x_dd的映射
        /// </summary>
        [XmlElement("x_open_id")]
        public string XOpenId { get; set; }
    }
}
