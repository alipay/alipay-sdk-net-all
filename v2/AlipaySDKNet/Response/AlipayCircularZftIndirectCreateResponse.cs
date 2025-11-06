using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCircularZftIndirectCreateResponse.
    /// </summary>
    public class AlipayCircularZftIndirectCreateResponse : AopResponse
    {
        /// <summary>
        /// 签约状态
        /// </summary>
        [XmlElement("prod_confirm")]
        public string ProdConfirm { get; set; }

        /// <summary>
        /// 进件申请单中的二级商户openid
        /// </summary>
        [XmlElement("relation_openid")]
        public string RelationOpenid { get; set; }

        /// <summary>
        /// 进件账户id
        /// </summary>
        [XmlElement("relation_uid")]
        public string RelationUid { get; set; }

        /// <summary>
        /// 进件状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 二级商户确认状态
        /// </summary>
        [XmlElement("sub_confirm")]
        public string SubConfirm { get; set; }
    }
}
