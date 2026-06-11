using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyFundBatchtransferQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyFundBatchtransferQueryModel : AopObject
    {
        /// <summary>
        /// 网商银行订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 由双方约定分配值
        /// </summary>
        [XmlElement("out_request_from")]
        public string OutRequestFrom { get; set; }

        /// <summary>
        /// 仅支持字母、数字，作为幂等字段，需保证在调用方内部不重复
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 数字人民币钱包编号
        /// </summary>
        [XmlElement("payer_wallet_id")]
        public string PayerWalletId { get; set; }
    }
}
