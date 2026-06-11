using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TransferDetail : AopObject
    {
        /// <summary>
        /// 转出金额，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 转账备注，不可使用特殊字符，如 /，=，& ，<，>等
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 请求方订单号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 收款方机构号
        /// </summary>
        [XmlElement("payee_inst_id")]
        public string PayeeInstId { get; set; }

        /// <summary>
        /// 收款方姓名
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 收款方钱包id
        /// </summary>
        [XmlElement("payee_wallet_id")]
        public string PayeeWalletId { get; set; }
    }
}
