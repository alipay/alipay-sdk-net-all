using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceapiBizuserQuitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceapiBizuserQuitModel : AopObject
    {
        /// <summary>
        /// 企业用户ID
        /// </summary>
        [XmlElement("biz_user_id")]
        public string BizUserId { get; set; }

        /// <summary>
        /// 星云分配给企业的产品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 星云给企业分配的租户code
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 星云用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
