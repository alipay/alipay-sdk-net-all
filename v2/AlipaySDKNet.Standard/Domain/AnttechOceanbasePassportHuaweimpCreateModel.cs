using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbasePassportHuaweimpCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbasePassportHuaweimpCreateModel : AopObject
    {
        /// <summary>
        /// 非必传，取值为加密后的登录凭证
        /// </summary>
        [XmlElement("credential")]
        public string Credential { get; set; }

        /// <summary>
        /// 客户在华为云注册账号的唯一标识。
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 客户在华为云注册的账户名
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 客户邮箱。非必传，如需此参数，在商品发布时“需要用户授权”请选择“基于邮箱创建应用管理账号等信息”
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 客户手机号。非必传，如需此参数，在商品发布时“需要用户授权”请选择“基于手机号码创建应用管理账号等信息”
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }
    }
}
