using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsMccInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BsMccInfo : AopObject
    {
        /// <summary>
        /// 门店对应的一级类目编码
        /// </summary>
        [XmlElement("mcc_code_1")]
        public string MccCode1 { get; set; }

        /// <summary>
        /// 门店对应的二级类目编码
        /// </summary>
        [XmlElement("mcc_code_2")]
        public string MccCode2 { get; set; }

        /// <summary>
        /// 门店对应的一级类目名称
        /// </summary>
        [XmlElement("mcc_name_1")]
        public string MccName1 { get; set; }

        /// <summary>
        /// 门店对应的二级类目名称
        /// </summary>
        [XmlElement("mcc_name_2")]
        public string MccName2 { get; set; }
    }
}
