using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniWidgetGoodsUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniWidgetGoodsUploadModel : AopObject
    {
        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("widget_goods_info")]
        public List<WidgetGoodsInfo> GoodsList { get; set; }

        /// <summary>
        /// 用于承接品的商家小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 品的售卖商家，即承接该品的小程序背后的商家。和mini_app_id要求对应
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
