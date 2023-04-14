using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdOrderCreateModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 计费方式： CPM-按展示次数收费
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 订单结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 订单名称
        /// </summary>
        [XmlElement("order_name")]
        public string OrderName { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放订单对应的外部资源ID
        /// </summary>
        [XmlElement("order_outer_id")]
        public string OrderOuterId { get; set; }

        /// <summary>
        /// 广告投放平台生成委托人ID
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 套餐ID
        /// </summary>
        [XmlElement("profile_id")]
        public long ProfileId { get; set; }

        /// <summary>
        /// 售卖方式： GD-合约交易
        /// </summary>
        [XmlElement("sell_mode")]
        public string SellMode { get; set; }

        /// <summary>
        /// 选点策略
        /// </summary>
        [XmlElement("site_strategy")]
        public SiteStrategy SiteStrategy { get; set; }

        /// <summary>
        /// 订单开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 外部平台门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 定向列表
        /// </summary>
        [XmlArray("targeting_list")]
        [XmlArrayItem("outer_targeting_item")]
        public List<OuterTargetingItem> TargetingList { get; set; }

        /// <summary>
        /// 广告投放平台生成广告主/代理商ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
