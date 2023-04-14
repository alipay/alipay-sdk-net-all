using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectBindUnbindResponse.
    /// </summary>
    public class AntMerchantExpandIndirectBindUnbindResponse : AopResponse
    {
        /// <summary>
        /// 支付宝登录号，脱敏展示
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 解绑结果，TRUE成功，FALSE失败
        /// </summary>
        [XmlElement("handle_result")]
        public string HandleResult { get; set; }

        /// <summary>
        /// 是否已经存在申请中的处理单
        /// </summary>
        [XmlElement("has_apply")]
        public string HasApply { get; set; }

        /// <summary>
        /// 申请单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
