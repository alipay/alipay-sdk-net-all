using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHdfServicerightConfirmResponse.
    /// </summary>
    public class AlipayCommerceHdfServicerightConfirmResponse : AopResponse
    {
        /// <summary>
        /// 业务身份
        /// </summary>
        [XmlElement("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// 占用信息
        /// </summary>
        [XmlElement("occupy_result")]
        public bool OccupyResult { get; set; }

        /// <summary>
        /// 外部userid
        /// </summary>
        [XmlElement("open_partner_user_id")]
        public string OpenPartnerUserId { get; set; }
    }
}
