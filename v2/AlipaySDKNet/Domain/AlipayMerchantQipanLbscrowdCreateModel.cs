using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanLbscrowdCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanLbscrowdCreateModel : AopObject
    {
        /// <summary>
        /// 安全应用范围，参考文档<a href="https://opendocs.alipay.com/pre-open/04phhq" target="_blank">安全应用范围枚举</a> <br> 未传值或传入渠道均非法时 采用默认渠道，默认渠道：支付结果页AA、繁星激励。 <br> 传入值时，以商户入参为准。
        /// </summary>
        [XmlArray("apply_channel_list")]
        [XmlArrayItem("string")]
        public List<string> ApplyChannelList { get; set; }

        /// <summary>
        /// 人群名称
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 门店范围 单位（米）
        /// </summary>
        [XmlElement("shop_distance")]
        public long ShopDistance { get; set; }

        /// <summary>
        /// 门店id列表
        /// </summary>
        [XmlArray("shop_id_list")]
        [XmlArrayItem("string")]
        public List<string> ShopIdList { get; set; }
    }
}
