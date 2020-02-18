using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTaxUserinfoQueryResponse.
    /// </summary>
    public class AlipayOverseasTaxUserinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户Id:蚂蚁统一会员ID,唯一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名:用户真实名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
