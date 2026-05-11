using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinCreditchangeNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinCreditchangeNotifyModel : AopObject
    {
        /// <summary>
        /// 星河侧唯一申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("credit_list")]
        [XmlArrayItem("credit")]
        public List<Credit> CreditList { get; set; }

        /// <summary>
        /// 是 机构侧唯一业务编号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }
    }
}
