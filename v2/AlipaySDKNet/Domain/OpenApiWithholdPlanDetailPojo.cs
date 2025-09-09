using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiWithholdPlanDetailPojo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiWithholdPlanDetailPojo : AopObject
    {
        /// <summary>
        /// 还款期数，1表示第一期
        /// </summary>
        [XmlElement("period_no")]
        public long PeriodNo { get; set; }

        /// <summary>
        /// 本期待换金额（单位分）
        /// </summary>
        [XmlElement("to_repay_amount")]
        public long ToRepayAmount { get; set; }

        /// <summary>
        /// 代扣日期
        /// </summary>
        [XmlElement("withhold_date")]
        public string WithholdDate { get; set; }
    }
}
