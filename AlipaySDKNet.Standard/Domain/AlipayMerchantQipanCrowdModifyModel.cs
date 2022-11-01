using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCrowdModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCrowdModifyModel : AopObject
    {
        /// <summary>
        /// 人群应用渠道。
        /// </summary>
        [XmlArray("apply_channel_list")]
        [XmlArrayItem("string")]
        public List<string> ApplyChannelList { get; set; }

        /// <summary>
        /// 支付宝人群code
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 商家人群名称
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }
    }
}
