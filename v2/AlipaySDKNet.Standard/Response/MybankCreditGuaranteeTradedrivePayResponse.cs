using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditGuaranteeTradedrivePayResponse.
    /// </summary>
    public class MybankCreditGuaranteeTradedrivePayResponse : AopResponse
    {
        /// <summary>
        /// 调用成功则返回调用业务编码
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
