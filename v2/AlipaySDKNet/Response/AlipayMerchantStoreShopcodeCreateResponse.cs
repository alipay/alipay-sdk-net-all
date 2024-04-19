using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantStoreShopcodeCreateResponse.
    /// </summary>
    public class AlipayMerchantStoreShopcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请流水ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 商户确认地址
        /// </summary>
        [XmlElement("confirm_url")]
        public string ConfirmUrl { get; set; }

        /// <summary>
        /// 门店码开通结果码，详细可参考文档下方统一对外错误码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 门店码开通结果提示，详细可参考文档下方统一对外错误码
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 开通门店码请求状态码，提交后一般为“等待商户确认”状态(WAIT_MERCHANT_CONFIRM)。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
