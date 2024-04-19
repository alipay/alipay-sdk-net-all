using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WalletOperation Data Structure.
    /// </summary>
    [Serializable]
    public class WalletOperation : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 交易时间
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
        /// 钱包账户交易金额，单位元
        /// </summary>
        [XmlElement("wallet_trans_amount")]
        public string WalletTransAmount { get; set; }
    }
}
