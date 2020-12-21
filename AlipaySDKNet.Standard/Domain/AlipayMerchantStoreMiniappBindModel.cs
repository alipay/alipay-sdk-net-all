using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantStoreMiniappBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantStoreMiniappBindModel : AopObject
    {
        /// <summary>
        /// 门店小程序绑定操作的类型，分为以下枚举类型： - STORE_DEFAULT_MINIAPP，门店默认小程序
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 门店和小程序绑定映射关系
        /// </summary>
        [XmlArray("shop_app_relation")]
        [XmlArrayItem("shop_app_relation")]
        public List<ShopAppRelation> ShopAppRelation { get; set; }
    }
}
