using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopProductCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopProductCreateModel : AopObject
    {
        /// <summary>
        /// app信息
        /// </summary>
        [XmlElement("inteop_app_info")]
        public InteOpAppInfo InteopAppInfo { get; set; }

        /// <summary>
        /// 商户营业执照信息
        /// </summary>
        [XmlElement("inteop_business_license_info")]
        public InteOpBusinessLicenseInfo InteopBusinessLicenseInfo { get; set; }

        /// <summary>
        /// h5信息
        /// </summary>
        [XmlElement("inteop_h_5_info")]
        public InteOpHtmlFiveInfo InteopH5Info { get; set; }

        /// <summary>
        /// 商户基本信息
        /// </summary>
        [XmlElement("inteop_merchant_info")]
        public InteOpMerchantInfo InteopMerchantInfo { get; set; }

        /// <summary>
        /// 小程序信息
        /// </summary>
        [XmlElement("inteop_mini_app_info")]
        public InteOpMiniAppInfo InteopMiniAppInfo { get; set; }

        /// <summary>
        /// 业务开通单号
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }

        /// <summary>
        /// 产品开通明细信息，为空的话则默认开通产品下属所有明细
        /// </summary>
        [XmlArray("inteop_product_details")]
        [XmlArrayItem("product_detail")]
        public List<ProductDetail> InteopProductDetails { get; set; }

        /// <summary>
        /// 产品费率明细信息
        /// </summary>
        [XmlArray("inteop_product_price_details")]
        [XmlArrayItem("product_price_info")]
        public List<ProductPriceInfo> InteopProductPriceDetails { get; set; }

        /// <summary>
        /// 店铺信息
        /// </summary>
        [XmlElement("inteop_shop_info")]
        public InteOpShopInfo InteopShopInfo { get; set; }

        /// <summary>
        /// 特殊行业资质信息 当前字段已废弃(特殊资质类型升级该参数为数组)
        /// </summary>
        [XmlElement("inteop_special_license_info")]
        public InteOpSpecialLicenseInfo InteopSpecialLicenseInfo { get; set; }

        /// <summary>
        /// 特殊行业资质信息
        /// </summary>
        [XmlArray("inteop_special_license_infos")]
        [XmlArrayItem("inte_op_special_license_info")]
        public List<InteOpSpecialLicenseInfo> InteopSpecialLicenseInfos { get; set; }

        /// <summary>
        /// 网站信息
        /// </summary>
        [XmlElement("inteop_web_site_info")]
        public InteOpWebSiteInfo InteopWebSiteInfo { get; set; }

        /// <summary>
        /// 所属MccCode，详情可参考 <a href="https://opendocs.alipay.com/common/02khjv">商家经营类目2.0</a>。
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// 移动设备类型。
        /// </summary>
        [XmlElement("mobile_type")]
        public string MobileType { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 交易场景。
        /// </summary>
        [XmlElement("trade_scene")]
        public string TradeScene { get; set; }
    }
}
