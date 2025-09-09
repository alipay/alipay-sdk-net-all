using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSubOrderInspectConfirmVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSubOrderInspectConfirmVO : AopObject
    {
        /// <summary>
        /// 回收的子单号
        /// </summary>
        [XmlElement("sub_order_id")]
        public string SubOrderId { get; set; }

        /// <summary>
        /// 子单质检金额，币种：人民币，单位：元
        /// </summary>
        [XmlElement("sub_order_inspect_price")]
        public string SubOrderInspectPrice { get; set; }

        /// <summary>
        /// 子单质检商品列表
        /// </summary>
        [XmlArray("sub_order_inspect_product_list")]
        [XmlArrayItem("recycle_sub_order_inspect_product_v_o")]
        public List<RecycleSubOrderInspectProductVO> SubOrderInspectProductList { get; set; }

        /// <summary>
        /// 商家的子单号
        /// </summary>
        [XmlElement("sub_out_order_id")]
        public string SubOutOrderId { get; set; }
    }
}
