using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinValuationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinValuationQueryModel : AopObject
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 机构申请单号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }
    }
}
