using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniWidgetGoodsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniWidgetGoodsQueryModel : AopObject
    {
        /// <summary>
        /// 根据商品的唯一标识查询
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 根据承接品的商家小程序ID查询
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 查询第几页，最小值为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 查询页面数量，最大值为50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 根据承接该品的小程序背后的商家查询
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
