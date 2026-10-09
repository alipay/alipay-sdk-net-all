using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class MpcItemVO : AopObject
    {
        /// <summary>
        /// 支付商品类目
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 1=官方插件版;0=自定义详情页版
        /// </summary>
        [XmlElement("detail_page_model")]
        public string DetailPageModel { get; set; }

        /// <summary>
        /// 副图
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 商品主图链接
        /// </summary>
        [XmlElement("main_pic")]
        public string MainPic { get; set; }

        /// <summary>
        /// 小程序云营销商品id
        /// </summary>
        [XmlElement("mpc_item_id")]
        public string MpcItemId { get; set; }

        /// <summary>
        /// 小程序智能营销sku信息
        /// </summary>
        [XmlArray("mpc_sku_vo")]
        [XmlArrayItem("mpc_sku_v_o")]
        public List<MpcSkuVO> MpcSkuVo { get; set; }

        /// <summary>
        /// 商家商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商品详情页URL
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
