using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOfflinelaborInsuranceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOfflinelaborInsuranceQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝账号，与channel_user_source 配对使用
        /// </summary>
        [XmlElement("channel_user_id")]
        public string ChannelUserId { get; set; }

        /// <summary>
        /// 渠道账号来源，"1" =支付宝账号
        /// </summary>
        [XmlElement("channel_user_source")]
        public string ChannelUserSource { get; set; }

        /// <summary>
        /// 保险模式
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 渠道账号对应UID，与channel_user_source 配对使用
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("product_list")]
        [XmlArrayItem("string")]
        public List<string> ProductList { get; set; }

        /// <summary>
        /// 已出单:ISSUED 已退保:SURRENDERRED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 搜索用户类型， "1"=按商户搜索
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
