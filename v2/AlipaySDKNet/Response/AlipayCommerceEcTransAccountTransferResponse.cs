using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTransAccountTransferResponse.
    /// </summary>
    public class AlipayCommerceEcTransAccountTransferResponse : AopResponse
    {
        /// <summary>
        /// 支付宝转账单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// SUCCESS：成功（对转账到银行卡的单据, 该状态可能变为退票[REFUND]）； FAIL：失败； DEALING：处理中（转账到支付宝账户不涉及）； REFUND：退票（转账到支付宝账户不涉及）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
