using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// HuanxuTradeOrderDisburseResponse.
    /// </summary>
    public class HuanxuTradeOrderDisburseResponse : AopResponse
    {
        /// <summary>
        /// 聚合支付的支付渠道，焕旭分配。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 打款金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("disburse_amount")]
        public string DisburseAmount { get; set; }

        /// <summary>
        /// 打款id，焕旭针对每一笔打款请求生成的唯一打款凭证
        /// </summary>
        [XmlElement("disburse_id")]
        public string DisburseId { get; set; }

        /// <summary>
        /// 打款请求号，对应一笔业务订单下的一次打款请求，不同打款请求需保证请求号唯一
        /// </summary>
        [XmlElement("disburse_request_no")]
        public string DisburseRequestNo { get; set; }

        /// <summary>
        /// 打款状态，目前支持如下值： WAIT（打款已受理），打款到银行渠道时会有该状态，业务上需等待后续的异步打款通知来确定最终的打款结果； SUCCESS（打款成功），该状态表示该笔打款已成功处理； FAIL（打款失败），该状态表示该笔打款已失败，并且不可重试，后续如果要重新打款，需要更换打款请求号。
        /// </summary>
        [XmlElement("disburse_status")]
        public string DisburseStatus { get; set; }

        /// <summary>
        /// 用于透传扩展信息，pay_url为支付链接。
        /// </summary>
        [XmlElement("ext_context")]
        public ExtContext ExtContext { get; set; }
    }
}
