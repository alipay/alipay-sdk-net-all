using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpOperationResultQueryResponse.
    /// </summary>
    public class AlipayOpenSpOperationResultQueryResponse : AopResponse
    {
        /// <summary>
        /// 被代运营者为间连商户时有值，此时返回绑定的支付宝账号。
        /// </summary>
        [XmlElement("bind_user_id")]
        public string BindUserId { get; set; }

        /// <summary>
        /// 轮询结果。SUCCESS代表成功;PROCESS处理中
        /// </summary>
        [XmlElement("handle_status")]
        public string HandleStatus { get; set; }

        /// <summary>
        /// 被代运营的商户号。
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }
    }
}
