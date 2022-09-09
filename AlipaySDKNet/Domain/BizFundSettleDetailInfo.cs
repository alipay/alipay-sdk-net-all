using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizFundSettleDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BizFundSettleDetailInfo : AopObject
    {
        /// <summary>
        /// 入账金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 分账状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 入账账户
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 入账账户类型
        /// </summary>
        [XmlElement("trans_in_type")]
        public string TransInType { get; set; }
    }
}
