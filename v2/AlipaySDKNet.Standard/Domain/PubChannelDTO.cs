using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PubChannelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PubChannelDTO : AopObject
    {
        /// <summary>
        /// 扩展信息，无需配置
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 投放渠道类型（选择需要推广投放的渠道） SHOP_DETAIL：店铺详情页
        /// </summary>
        [XmlElement("pub_channel")]
        public string PubChannel { get; set; }
    }
}
