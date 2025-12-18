using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSolutionprodMerchantupgradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSolutionprodMerchantupgradeQueryModel : AopObject
    {
        /// <summary>
        /// 调用alipay.trade.solutionprod.merchantupgrade.apply返回的个人用户升级申请单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部请求流水号，调用alipay.trade.solutionprod.merchantupgrade.apply接口时传入
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
