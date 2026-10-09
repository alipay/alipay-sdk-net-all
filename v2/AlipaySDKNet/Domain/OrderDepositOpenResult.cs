using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderDepositOpenResult Data Structure.
    /// </summary>
    [Serializable]
    public class OrderDepositOpenResult : AopObject
    {
        /// <summary>
        /// 入账金额，单位：元
        /// </summary>
        [XmlElement("deposit_amount")]
        public string DepositAmount { get; set; }

        /// <summary>
        /// 入账单类型
        /// </summary>
        [XmlElement("deposit_direction")]
        public string DepositDirection { get; set; }

        /// <summary>
        /// 入账单号
        /// </summary>
        [XmlElement("deposit_id")]
        public string DepositId { get; set; }

        /// <summary>
        /// 入账单状态
        /// </summary>
        [XmlElement("deposit_status")]
        public string DepositStatus { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }
    }
}
