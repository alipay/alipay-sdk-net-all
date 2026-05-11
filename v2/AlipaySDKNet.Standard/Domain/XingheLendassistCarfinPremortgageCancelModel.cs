using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinPremortgageCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinPremortgageCancelModel : AopObject
    {
        /// <summary>
        /// 星河侧唯一申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 支用申请单号
        /// </summary>
        [XmlElement("lend_apply_no")]
        public string LendApplyNo { get; set; }

        /// <summary>
        /// 抵押订单号
        /// </summary>
        [XmlElement("mortgage_no")]
        public string MortgageNo { get; set; }

        /// <summary>
        /// 机构侧唯一业务编号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 外部支用申请单号
        /// </summary>
        [XmlElement("out_lend_apply_no")]
        public string OutLendApplyNo { get; set; }
    }
}
