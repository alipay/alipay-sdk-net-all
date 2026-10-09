using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantGoodsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMerchantGoodsSyncModel : AopObject
    {
        /// <summary>
        /// 同步的宝贝信息列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("hb_mei_wei_item_sync")]
        public List<HbMeiWeiItemSync> ItemList { get; set; }

        /// <summary>
        /// 商家宝贝信息同步，商户请求蚂蚁侧
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
