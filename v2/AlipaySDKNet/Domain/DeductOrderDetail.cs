using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductOrderDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DeductOrderDetail : AopObject
    {
        /// <summary>
        /// ● 单位：元 ● 格式：1元 = "1.00"，0元 = "0.00"
        /// </summary>
        [XmlElement("deduct_amount")]
        public string DeductAmount { get; set; }

        /// <summary>
        /// 长度不能超过256，若超过，请联系仕强
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// ● 单位：元 ● 格式：1元 = "1.00"，0元 = "0.00" ● 已废弃 当前字段已废弃(为防止客户理解错误，废弃该字段)
        /// </summary>
        [XmlElement("produce_amount")]
        public string ProduceAmount { get; set; }

        /// <summary>
        /// ● 单位：元 ● 格式：1元 = "1.00"，0元 = "0.00" ● 说明：积分抵扣前总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
