using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleAssessProductVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleAssessProductVO : AopObject
    {
        /// <summary>
        /// 估价最高金额、固定价
        /// </summary>
        [XmlElement("assess_amount")]
        public string AssessAmount { get; set; }

        /// <summary>
        /// 单位：元。 当估价类型=区间价的时候，需要传入
        /// </summary>
        [XmlElement("assess_min_amount")]
        public string AssessMinAmount { get; set; }

        /// <summary>
        /// 最低重量
        /// </summary>
        [XmlElement("assess_min_quality")]
        public string AssessMinQuality { get; set; }

        /// <summary>
        /// 除去称重外，其他3C、酒水、潮奢按unit_type=piece件计数
        /// </summary>
        [XmlElement("assess_quality")]
        public string AssessQuality { get; set; }

        /// <summary>
        /// FIXED：固定价  RANGE_UNIT：浮动数量固定单价，如统收衣物称斤 --对应区间重量  RANGE_PRICE：区间价，如潮奢、酒水 --对应区间价
        /// </summary>
        [XmlElement("assess_type")]
        public string AssessType { get; set; }

        /// <summary>
        /// 回收商户的产品编码
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 回收商的产品名称
        /// </summary>
        [XmlElement("out_sku_name")]
        public string OutSkuName { get; set; }

        /// <summary>
        /// 3C品类 ● 手机PHONE ● 电脑COMPUTER ● 平板PAD ● 智能手表WATCH ● 手环BAND ● 无人机DRONE ● 游戏机GAME ● 数码配件ACCESSORIES ● 相机CAMERA ● 其他数码产品OTHERS  潮品: FASHION 奢品: LUXURY
        /// </summary>
        [XmlElement("product_category")]
        public string ProductCategory { get; set; }

        /// <summary>
        /// 支付宝侧的产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品图片
        /// </summary>
        [XmlElement("product_logo")]
        public string ProductLogo { get; set; }

        /// <summary>
        /// 支付宝侧的回收产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// PIECE：一部手机、一瓶酒水 KG：衣物称斤，一公斤 G：黄金按克重算单价
        /// </summary>
        [XmlElement("unit_type")]
        public string UnitType { get; set; }
    }
}
