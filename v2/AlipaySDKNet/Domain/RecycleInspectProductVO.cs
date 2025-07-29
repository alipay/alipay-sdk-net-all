using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleInspectProductVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleInspectProductVO : AopObject
    {
        /// <summary>
        /// 单个产品的质检金额
        /// </summary>
        [XmlElement("inspect_price")]
        public string InspectPrice { get; set; }

        /// <summary>
        /// 商户侧的产品编码
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商户产品名称
        /// </summary>
        [XmlElement("out_sku_name")]
        public string OutSkuName { get; set; }

        /// <summary>
        /// 回收品类 ● 手机PHONE ● 电脑COMPUTER ● 平板PAD ● 智能手表WATCH ● 手环BAND ● 无人机DRONE ● 游戏机GAME ● 数码配件ACCESSORIES ● 相机CAMERA ● 其他数码产品OTHERS
        /// </summary>
        [XmlElement("product_category")]
        public string ProductCategory { get; set; }

        /// <summary>
        /// 支付宝侧的标准产品编码, 和商户外部OUT_SKU_ID二选一填入
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
