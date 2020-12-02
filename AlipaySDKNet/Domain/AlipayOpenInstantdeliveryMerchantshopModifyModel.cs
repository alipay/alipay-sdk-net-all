using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenInstantdeliveryMerchantshopModifyModel : AopObject
    {
        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 要更新的配送公司列表，必须包含已经创建过该门店的配送公司，可以新增开通了账户的配送公司
        /// </summary>
        [XmlArray("logistics_codes")]
        [XmlArrayItem("string")]
        public List<string> LogisticsCodes { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 联系人电话/手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 商家门店编码
        /// </summary>
        [XmlElement("shop_no")]
        public string ShopNo { get; set; }
    }
}
