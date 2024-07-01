using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionFundstransferQuerystatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySupervisionFundstransferQuerystatusModel : AopObject
    {
        /// <summary>
        /// 不同的业务场景下对应不同的业务规则
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 资金划拨请求接口或者退款接口返回的支付宝内部受理生成的流水单号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 在商户发起退款、资金划拨操作时请求参数中的「外部流水号 out_trade_no 」
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
