using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialShopstaffQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialShopstaffQueryResponse : AopResponse
    {
        /// <summary>
        /// 店员支付宝登录账号，手机号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 描述店员角色信息 角色： ADMIN 管理员 MEMBER 店员
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 医疗门店店员名称
        /// </summary>
        [XmlElement("staff_name")]
        public string StaffName { get; set; }
    }
}
