using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardOpenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardOpenCreateModel : AopObject
    {
        /// <summary>
        /// 卡类型
        /// </summary>
        [XmlArray("card_types")]
        [XmlArrayItem("string")]
        public List<string> CardTypes { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 是否需要代运营授权
        /// </summary>
        [XmlElement("need_auth")]
        public bool NeedAuth { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 价格关联key
        /// </summary>
        [XmlArray("price_infos")]
        [XmlArrayItem("merchant_price_rel_info")]
        public List<MerchantPriceRelInfo> PriceInfos { get; set; }

        /// <summary>
        /// 资质
        /// </summary>
        [XmlElement("settle_in_merchant_license")]
        public SettleInMerchantLicense SettleInMerchantLicense { get; set; }
    }
}
