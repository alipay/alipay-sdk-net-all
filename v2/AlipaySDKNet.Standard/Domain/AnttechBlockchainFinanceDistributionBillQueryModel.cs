using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceDistributionBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceDistributionBillQueryModel : AopObject
    {
        /// <summary>
        /// 收益分配账单Id 二选一
        /// </summary>
        [XmlElement("distribution_order_id")]
        public string DistributionOrderId { get; set; }

        /// <summary>
        /// 收益分配产品码, 请咨询业务同学
        /// </summary>
        [XmlElement("distribution_pro_no")]
        public string DistributionProNo { get; set; }

        /// <summary>
        /// 核销流水 二选一
        /// </summary>
        [XmlElement("write_off_biz_no")]
        public string WriteOffBizNo { get; set; }
    }
}
