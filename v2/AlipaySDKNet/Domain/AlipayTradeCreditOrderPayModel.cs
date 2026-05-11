using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCreditOrderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCreditOrderPayModel : AopObject
    {
        /// <summary>
        /// 场景参数，标识还款场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 信用服务订单号
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }
    }
}
