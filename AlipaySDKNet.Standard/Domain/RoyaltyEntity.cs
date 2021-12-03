using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoyaltyEntity Data Structure.
    /// </summary>
    [Serializable]
    public class RoyaltyEntity : AopObject
    {
        /// <summary>
        /// 分账接收方账号。 当分账方类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字； 当分账方类型是loginName时，本参数为用户的支付宝登录号。
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 分账关系描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 分账接收方真实姓名。 绑定分账关系时： 当分账方类型是userId时，本参数可以不传，若上传则进行校验不上传不会校验。 当分账方类型是loginName时，本参数必传。 解绑分账关系时：作为请求参数可不填，分账关系查询时不作为返回结果返回
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分账接收方方类型。 userId：表示是支付宝账号对应的支付宝唯一用户号；loginName：表示是支付宝登录号
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
