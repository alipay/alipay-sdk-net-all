using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandEcoOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandEcoOrderCreateModel : AopObject
    {
        /// <summary>
        /// 交易平台
        /// </summary>
        [XmlElement("busi_platform")]
        public string BusiPlatform { get; set; }

        /// <summary>
        /// 卖家编号，取值方式：卖家编号即可
        /// </summary>
        [XmlElement("eco_code")]
        public string EcoCode { get; set; }

        /// <summary>
        /// 运单号。取值方式是：实际运单号即可
        /// </summary>
        [XmlElement("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 交易平台订单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 数组，商品图片file_key，就是在订单上传之前需要先上传订单对应的商品图片，上传成功之后返回的oss_key
        /// </summary>
        [XmlArray("product_image_file_keys")]
        [XmlArrayItem("string")]
        public List<string> ProductImageFileKeys { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [XmlElement("product_specifications")]
        public string ProductSpecifications { get; set; }

        /// <summary>
        /// osskey数组,将文件上传的返回的osskey一并上传
        /// </summary>
        [XmlArray("qrcode_imgs")]
        [XmlArrayItem("string")]
        public List<string> QrcodeImgs { get; set; }

        /// <summary>
        /// 码值url链接(必须是支付宝的码值),数组。取值方式是：用户上传码值链接即可
        /// </summary>
        [XmlArray("qrcode_tokens")]
        [XmlArrayItem("string")]
        public List<string> QrcodeTokens { get; set; }

        /// <summary>
        /// 确认收货时间
        /// </summary>
        [XmlElement("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 店铺名称，取生态供应商店铺名称即可
        /// </summary>
        [XmlElement("shop_code")]
        public string ShopCode { get; set; }

        /// <summary>
        /// nfc线圈的tag_id
        /// </summary>
        [XmlArray("tag_ids")]
        [XmlArrayItem("string")]
        public List<string> TagIds { get; set; }
    }
}
