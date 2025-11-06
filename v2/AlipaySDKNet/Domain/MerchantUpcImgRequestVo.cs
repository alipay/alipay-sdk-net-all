using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantUpcImgRequestVo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantUpcImgRequestVo : AopObject
    {
        /// <summary>
        /// 官方商品code
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 国标码
        /// </summary>
        [XmlElement("goods_upc")]
        public string GoodsUpc { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 转存后支付宝图片url
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 是否主图
        /// </summary>
        [XmlElement("is_main")]
        public long IsMain { get; set; }

        /// <summary>
        /// 商户appId
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 商家图片url
        /// </summary>
        [XmlElement("merchant_img_url")]
        public string MerchantImgUrl { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }
    }
}
