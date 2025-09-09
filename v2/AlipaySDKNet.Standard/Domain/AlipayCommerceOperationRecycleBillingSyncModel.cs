using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationRecycleBillingSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationRecycleBillingSyncModel : AopObject
    {
        /// <summary>
        /// 资金明细集合
        /// </summary>
        [XmlArray("funds_details")]
        [XmlArrayItem("recycle_funds_info")]
        public List<RecycleFundsInfo> FundsDetails { get; set; }

        /// <summary>
        /// 回收订单来源, 比价插件: ALIPAY_PRICE_COMPARISON, 回收派单: ALIPAY_RECYCLE_DISPATCH
        /// </summary>
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 商户侧回收单号
        /// </summary>
        [XmlElement("out_biz_recycle_id")]
        public string OutBizRecycleId { get; set; }
    }
}
