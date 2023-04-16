using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspVidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspVidQueryModel : AopObject
    {
        /// <summary>
        /// 商家的id
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 用户的openId，uid和open_id至少传一个
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 机构外标
        /// </summary>
        [XmlElement("org_out_id")]
        public string OrgOutId { get; set; }

        /// <summary>
        /// 支付宝账号的id，uid和open_id至少传一个
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
