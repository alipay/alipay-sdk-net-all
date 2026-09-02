using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandEcoEmptycodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandEcoEmptycodeCreateModel : AopObject
    {
        /// <summary>
        /// 交易平台
        /// </summary>
        [XmlElement("busi_platform")]
        public string BusiPlatform { get; set; }

        /// <summary>
        /// 空码包装日期
        /// </summary>
        [XmlElement("code_pack_date")]
        public string CodePackDate { get; set; }

        /// <summary>
        /// 卖家编号，取值方式：卖家编号即可
        /// </summary>
        [XmlElement("eco_code")]
        public string EcoCode { get; set; }

        /// <summary>
        /// 码值url链接(必须是支付宝的码值)
        /// </summary>
        [XmlElement("qrcode_token")]
        public string QrcodeToken { get; set; }

        /// <summary>
        /// 店铺名称，取生态供应商店铺名称即可
        /// </summary>
        [XmlElement("shop_code")]
        public string ShopCode { get; set; }
    }
}
