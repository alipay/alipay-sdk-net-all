using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Data Data Structure.
    /// </summary>
    [Serializable]
    public class Data : AopObject
    {
        /// <summary>
        /// 支付宝用户唯一标识列表
        /// </summary>
        [XmlArray("alipay_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> AlipayOpenIdList { get; set; }

        /// <summary>
        /// 对应userIdList，标准Alipay UserId列表
        /// </summary>
        [XmlArray("alipay_user_id_list")]
        [XmlArrayItem("string")]
        public List<string> AlipayUserIdList { get; set; }

        /// <summary>
        /// 支付宝用户唯一标识列表
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OpenIdList { get; set; }

        /// <summary>
        /// 用户id列表
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
