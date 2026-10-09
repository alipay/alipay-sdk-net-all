using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplierDeliveryBatch Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierDeliveryBatch : AopObject
    {
        /// <summary>
        /// 实发数量
        /// </summary>
        [XmlElement("actual_amount")]
        public long ActualAmount { get; set; }

        /// <summary>
        /// 批次编号, 20190721001
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 过期日期(YYYY-MM-DD)
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 生产批号
        /// </summary>
        [XmlElement("produce_code")]
        public string ProduceCode { get; set; }

        /// <summary>
        /// 生产日期(YYYY-MM-DD)
        /// </summary>
        [XmlElement("produce_date")]
        public string ProduceDate { get; set; }
    }
}
