using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringConfigModifyResponse.
    /// </summary>
    public class KoubeiCateringConfigModifyResponse : AopResponse
    {
        /// <summary>
        /// 每一个店铺修改的结果
        /// </summary>
        [XmlArray("config_result_list")]
        [XmlArrayItem("shop_order_modify_result")]
        public List<ShopOrderModifyResult> ConfigResultList { get; set; }
    }
}
