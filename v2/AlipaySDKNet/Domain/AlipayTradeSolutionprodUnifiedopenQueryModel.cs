using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSolutionprodUnifiedopenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSolutionprodUnifiedopenQueryModel : AopObject
    {
        /// <summary>
        /// 外部请求流水号，调用alipay.trade.solutionprod.unifiedopen.apply接口时传入
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 调用alipay.merchant.ctoc.unifiedopen.apply 返回的聚合开通申请单号
        /// </summary>
        [XmlElement("uniopen_order_id")]
        public string UniopenOrderId { get; set; }
    }
}
