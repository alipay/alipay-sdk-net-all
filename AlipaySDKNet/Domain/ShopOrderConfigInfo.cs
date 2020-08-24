using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopOrderConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopOrderConfigInfo : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 店铺营业状态：  可枚举：  (1)OPEN 营业  (2)CLOSE 休息
        /// </summary>
        [XmlElement("order_entry_status")]
        public string OrderEntryStatus { get; set; }

        /// <summary>
        /// 点餐一般营业营业时间配置
        /// </summary>
        [XmlArray("order_normal_business_time")]
        [XmlArrayItem("normal_business_time_rule")]
        public List<NormalBusinessTimeRule> OrderNormalBusinessTime { get; set; }

        /// <summary>
        /// 点餐特殊营业时间规则配置
        /// </summary>
        [XmlArray("order_special_business_time")]
        [XmlArrayItem("special_business_time_rule")]
        public List<SpecialBusinessTimeRule> OrderSpecialBusinessTime { get; set; }

        /// <summary>
        /// OPEN表示打开点餐服务 CLOSED表示关闭点餐服务
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 预点餐（轻快餐自提）相关设置。若字段为空，表示无需修改。
        /// </summary>
        [XmlElement("pre_order_config")]
        public PreOrderConfigInfo PreOrderConfig { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 外部门店编号；最长32位字符，该编号将作为收单接口的入参， 请开发者自行确保其唯一性。
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
