using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSolutionprodMerchantupgradeQueryResponse.
    /// </summary>
    public class AlipayTradeSolutionprodMerchantupgradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 升级操作时的支付宝登录号（脱敏）
        /// </summary>
        [XmlElement("binding_logon_id")]
        public string BindingLogonId { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 个人用户升级申请单号，个人用户升级申请后由支付宝生成返回
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部请求流水号，调用alipay.trade.solutionprod.merchantupgrade.apply接口时由商户传入
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 升级的smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// INIT:已申请用户还未确认 、ROCESSING：升级中 、SUCCESS:升级成功 、RETYR:当前升级失败，根据错误原因进行排查，解决后可用原单进行重试
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
