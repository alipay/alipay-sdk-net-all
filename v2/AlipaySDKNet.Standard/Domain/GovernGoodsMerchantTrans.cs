using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GovernGoodsMerchantTrans Data Structure.
    /// </summary>
    [Serializable]
    public class GovernGoodsMerchantTrans : AopObject
    {
        /// <summary>
        /// 异常交易ID
        /// </summary>
        [XmlArray("error_transaction_id")]
        [XmlArrayItem("string")]
        public List<string> ErrorTransactionId { get; set; }

        /// <summary>
        /// 人工单笔数，单位笔
        /// </summary>
        [XmlElement("manual_trans_count")]
        public long ManualTransCount { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 二级商户ID
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 1:商户+商品，2:二级商户+商品
        /// </summary>
        [XmlElement("task_type")]
        public long TaskType { get; set; }

        /// <summary>
        /// 交易笔数，单位笔
        /// </summary>
        [XmlElement("trans_count")]
        public long TransCount { get; set; }
    }
}
