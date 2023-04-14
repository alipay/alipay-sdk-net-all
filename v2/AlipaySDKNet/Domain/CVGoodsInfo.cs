using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CVGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CVGoodsInfo : AopObject
    {
        /// <summary>
        /// 对应算法id
        /// </summary>
        [XmlElement("algorithm_id")]
        public string AlgorithmId { get; set; }

        /// <summary>
        /// 商品大类
        /// </summary>
        [XmlElement("big_category")]
        public string BigCategory { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 进深[毫米]-静态时需必填
        /// </summary>
        [XmlElement("depth")]
        public string Depth { get; set; }

        /// <summary>
        /// standardGoods为true时必填
        /// </summary>
        [XmlElement("gb_code")]
        public string GbCode { get; set; }

        /// <summary>
        /// 商品SKU的名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 高[毫米]-静态时需必填
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 1(正面)、2(左侧)、3(右侧)、4(背面)、5(顶部)，6(底部)、7(69码特写照)
        /// </summary>
        [XmlElement("img_info")]
        public string ImgInfo { get; set; }

        /// <summary>
        /// 对应主外观算法id
        /// </summary>
        [XmlElement("main_algorithm_id")]
        public string MainAlgorithmId { get; set; }

        /// <summary>
        /// 软包类型
        /// </summary>
        [XmlElement("package_type")]
        public string PackageType { get; set; }

        /// <summary>
        /// 商品小类
        /// </summary>
        [XmlElement("small_category")]
        public string SmallCategory { get; set; }

        /// <summary>
        /// 是否标准商品，标准商品必填69码
        /// </summary>
        [XmlElement("standard_goods")]
        public bool StandardGoods { get; set; }

        /// <summary>
        /// 样本重量[克]：多个,分割
        /// </summary>
        [XmlElement("weight_list")]
        public string WeightList { get; set; }

        /// <summary>
        /// 宽[毫米]-静态时需必填
        /// </summary>
        [XmlElement("width")]
        public string Width { get; set; }
    }
}
