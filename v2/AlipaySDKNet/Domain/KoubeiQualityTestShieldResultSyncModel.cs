using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiQualityTestShieldResultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiQualityTestShieldResultSyncModel : AopObject
    {
        /// <summary>
        /// 口碑加购单号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 节点执行结果
        /// </summary>
        [XmlArray("check_result_list")]
        [XmlArrayItem("check_result_list")]
        public List<CheckResultList> CheckResultList { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号，在ISV点餐对接中，特指POS侧订单ID，在接单回执中由ISV给到口碑； 特别说明： 在首次点菜场景中，推单信息中此参数为空；在加菜场景中，此参数不为空；
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付类型。 ADVANCE_PAYMENT：先付； AFTER_PAYMENT：后付；
        /// </summary>
        [XmlElement("pay_style")]
        public string PayStyle { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
