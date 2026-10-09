using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayFlowModel Data Structure.
    /// </summary>
    [Serializable]
    public class PayFlowModel : AopObject
    {
        /// <summary>
        /// 是否查得
        /// </summary>
        [XmlElement("is_effective")]
        public string IsEffective { get; set; }

        /// <summary>
        /// 店铺信息列表
        /// </summary>
        [XmlArray("shop_list")]
        [XmlArrayItem("pay_flow_shop_info_model")]
        public List<PayFlowShopInfoModel> ShopList { get; set; }

        /// <summary>
        /// 店铺数量
        /// </summary>
        [XmlElement("shop_num")]
        public string ShopNum { get; set; }
    }
}
