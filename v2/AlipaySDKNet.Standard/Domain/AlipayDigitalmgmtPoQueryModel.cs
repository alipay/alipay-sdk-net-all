using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtPoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtPoQueryModel : AopObject
    {
        /// <summary>
        /// 实际需求方采购组织ID
        /// </summary>
        [XmlElement("demander_purchase_org_id")]
        public long DemanderPurchaseOrgId { get; set; }

        /// <summary>
        /// PO编号集合
        /// </summary>
        [XmlArray("po_number_list")]
        [XmlArrayItem("string")]
        public List<string> PoNumberList { get; set; }

        /// <summary>
        /// PO视图，控制接口返回的信息量，参考{PoViewEnum}用逗号分隔 外部接口希望PO聚合返回的信息量越来越多，为了支持更加灵活的信息组装方式，由上面的枚举改为String，方便后续扩展）  e.g. 希望返回"订单头+行+付款条款"："ITEM_INCLUDED,PAYMENT_PLAN_INCLUDED" e.g. 希望返回"订单头+行+行上扩展信息+付款条款"："ITEM_INCLUDED_AND_EXT_INFO_INCLUDED,PAYMENT_PLAN_INCLUDED" e.g. 希望返回"订单头+行+行上财务段值+付款条款"："ITEM_INCLUDED_AND_FINANCIAL_ATTRS,PAYMENT_PLAN_INCLUDED" e.g. 希望返回"订单头+付款条款"："PAYMENT_PLAN_INCLUDED"
        /// </summary>
        [XmlElement("po_view_control")]
        public string PoViewControl { get; set; }

        /// <summary>
        /// 明细上的接收人
        /// </summary>
        [XmlElement("receiver")]
        public string Receiver { get; set; }

        /// <summary>
        /// 状态集合
        /// </summary>
        [XmlArray("status")]
        [XmlArrayItem("string")]
        public List<string> Status { get; set; }

        /// <summary>
        /// 供应商ID (非必传,如果传按照指定供应商查询)
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
