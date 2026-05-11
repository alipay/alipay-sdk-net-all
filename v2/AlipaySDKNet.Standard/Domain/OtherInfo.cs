using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OtherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OtherInfo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ext_info_attrs")]
        [XmlArrayItem("ext_info_attrs")]
        public List<ExtInfoAttrs> ExtInfoAttrs { get; set; }

        /// <summary>
        /// 药房业务必填； 是否支持医保 true: 是 false: 否
        /// </summary>
        [XmlElement("medical_insurance")]
        public bool MedicalInsurance { get; set; }
    }
}
