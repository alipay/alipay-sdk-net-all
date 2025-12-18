using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillFeeItemReq Data Structure.
    /// </summary>
    [Serializable]
    public class BillFeeItemReq : AopObject
    {
        /// <summary>
        /// 费用金额，单位分
        /// </summary>
        [XmlElement("fee_amount")]
        public long FeeAmount { get; set; }

        /// <summary>
        /// 费用真实描述，注意和feeTitle区分开，此描述长度请保持在16个字以内 此字段直接显示在费用明细页面中
        /// </summary>
        [XmlElement("fee_desc")]
        public string FeeDesc { get; set; }

        /// <summary>
        /// 费用类型标识,枚举值,参考线下文档
        /// </summary>
        [XmlElement("fee_id")]
        public string FeeId { get; set; }

        /// <summary>
        /// 费用标题
        /// </summary>
        [XmlElement("fee_title")]
        public string FeeTitle { get; set; }
    }
}
