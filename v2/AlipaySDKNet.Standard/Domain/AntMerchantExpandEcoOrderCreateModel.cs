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
        /// 卖家编号
        /// </summary>
        [XmlElement("eco_code")]
        public string EcoCode { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("express_no")]
        public string ExpressNo { get; set; }

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
        /// osskey数组,将文件上传的返回的osskey一并上传
        /// </summary>
        [XmlArray("qrcode_imgs")]
        [XmlArrayItem("string")]
        public List<string> QrcodeImgs { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_code")]
        public string ShopCode { get; set; }
    }
}
