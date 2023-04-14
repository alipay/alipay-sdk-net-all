using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniWidgetDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniWidgetDataSyncModel : AopObject
    {
        /// <summary>
        /// 活动信息列表
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("widget_activity_info")]
        public List<WidgetActivityInfo> ActivityList { get; set; }

        /// <summary>
        /// 数据类型，可选值：ACTIVITY(活动数据)、GOODS(商品数据)
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("widget_goods_info")]
        public List<WidgetGoodsInfo> GoodsList { get; set; }

        /// <summary>
        /// 商家小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序背后的商家，和mini_app_id要求对应
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
