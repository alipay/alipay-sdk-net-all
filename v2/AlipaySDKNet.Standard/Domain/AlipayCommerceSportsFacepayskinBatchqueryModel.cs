using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsFacepayskinBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsFacepayskinBatchqueryModel : AopObject
    {
        /// <summary>
        /// 支付宝客户端版本号
        /// </summary>
        [XmlElement("client_version")]
        public string ClientVersion { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 付款码皮肤ID集合
        /// </summary>
        [XmlArray("skin_id_list")]
        [XmlArrayItem("string")]
        public List<string> SkinIdList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
