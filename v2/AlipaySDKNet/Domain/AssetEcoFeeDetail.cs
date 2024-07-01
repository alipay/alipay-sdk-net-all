using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetEcoFeeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssetEcoFeeDetail : AopObject
    {
        /// <summary>
        /// 账单主体
        /// </summary>
        [XmlElement("bill_entity")]
        public string BillEntity { get; set; }

        /// <summary>
        /// 费用金额 （单位元，四舍五入两位小数）
        /// </summary>
        [XmlElement("fee_price")]
        public string FeePrice { get; set; }

        /// <summary>
        /// 计费时间 （yyyy-MM-dd HH:mm:SS）
        /// </summary>
        [XmlElement("fee_time")]
        public string FeeTime { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [XmlElement("fee_type")]
        public string FeeType { get; set; }

        /// <summary>
        /// 单笔费用不可结算原因
        /// </summary>
        [XmlElement("unbill_reason")]
        public string UnbillReason { get; set; }
    }
}
