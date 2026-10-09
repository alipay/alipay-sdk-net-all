using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinRepayplanchangeNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinRepayplanchangeNotifyModel : AopObject
    {
        /// <summary>
        /// 星河申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 机构侧申请单号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }
    }
}
