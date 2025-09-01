using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentItemExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentItemExtInfo : AopObject
    {
        /// <summary>
        /// 券后签约价格，币种：人民币，单位：元
        /// </summary>
        [XmlElement("after_coupon_price")]
        public string AfterCouponPrice { get; set; }

        /// <summary>
        /// 商品的品牌名称
        /// </summary>
        [XmlElement("item_brand")]
        public string ItemBrand { get; set; }

        /// <summary>
        /// 商品的类目，取值：请联系支付宝租赁行业BD咨询
        /// </summary>
        [XmlElement("item_category")]
        public string ItemCategory { get; set; }

        /// <summary>
        /// 商品的颜色，例如：红色、蓝色、白色...
        /// </summary>
        [XmlElement("item_color")]
        public string ItemColor { get; set; }

        /// <summary>
        /// 商品型号，例如：iphone 12
        /// </summary>
        [XmlElement("item_model")]
        public string ItemModel { get; set; }

        /// <summary>
        /// 商品的名称，例如：iphone 16 pro max
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品的内存大小，如果是手机的时候需要设置，单位：GB/MB/KB
        /// </summary>
        [XmlElement("item_ram")]
        public string ItemRam { get; set; }

        /// <summary>
        /// 商品的成色
        /// </summary>
        [XmlElement("item_state")]
        public string ItemState { get; set; }

        /// <summary>
        /// 官网价，单位：元。
        /// </summary>
        [XmlElement("official_price")]
        public string OfficialPrice { get; set; }

        /// <summary>
        /// 商品的供应商名称，例如：深圳爱租机苹果供应商
        /// </summary>
        [XmlElement("provider_name")]
        public string ProviderName { get; set; }

        /// <summary>
        /// 商品的采购价格，币种：人民币，单位：元
        /// </summary>
        [XmlElement("purchasing_price")]
        public string PurchasingPrice { get; set; }

        /// <summary>
        /// 商品的设备序列号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
