using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenInstantdeliveryAccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenInstantdeliveryAccountCreateModel : AopObject
    {
        /// <summary>
        /// 配送公司编码
        /// </summary>
        [XmlArray("logistics_codes")]
        [XmlArrayItem("string")]
        public List<string> LogisticsCodes { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
