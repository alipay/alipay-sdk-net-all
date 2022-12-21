using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationProtocolAuthorizeUnsubscribeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceQuotationProtocolAuthorizeUnsubscribeModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 与蚂蚁业务方约定的类型，同时约定$orgCode值
        /// </summary>
        [XmlArray("protocol_type_list")]
        [XmlArrayItem("string")]
        public List<string> ProtocolTypeList { get; set; }

        /// <summary>
        /// 订阅个股还是全部，ALL表示全部，SYMBOL表示个股
        /// </summary>
        [XmlElement("sign_content")]
        public string SignContent { get; set; }

        /// <summary>
        /// 股票市场上的代码+市场组合的代码
        /// </summary>
        [XmlArray("symbols")]
        [XmlArrayItem("string")]
        public List<string> Symbols { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
