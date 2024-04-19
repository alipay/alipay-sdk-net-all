using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeAppMergePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeAppMergePayModel : AopObject
    {
        /// <summary>
        /// 预下单号。通过 alipay.trade.merge.precreate(统一收单合并支付预创建接口)返回。
        /// </summary>
        [XmlElement("pre_order_no")]
        public string PreOrderNo { get; set; }
    }
}
