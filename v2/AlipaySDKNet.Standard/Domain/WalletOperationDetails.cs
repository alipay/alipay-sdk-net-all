using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WalletOperationDetails Data Structure.
    /// </summary>
    [Serializable]
    public class WalletOperationDetails : AopObject
    {
        /// <summary>
        /// 业务类型【枚举值】 核销: PAYMENT 核销退: REFUND 充值: DEPOSIT 提现: WITHDRAW 充退: RETURN
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("trans_dt")]
        public string TransDt { get; set; }

        /// <summary>
        /// 交易订单
        /// </summary>
        [XmlArray("trans_order")]
        [XmlArrayItem("string")]
        public List<string> TransOrder { get; set; }

        /// <summary>
        /// 交易金额，单位元
        /// </summary>
        [XmlElement("wallet_trans_amount")]
        public string WalletTransAmount { get; set; }
    }
}
