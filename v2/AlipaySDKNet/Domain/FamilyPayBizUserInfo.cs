using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FamilyPayBizUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FamilyPayBizUserInfo : AopObject
    {
        /// <summary>
        /// 支付宝user_id，代表亲情卡赠卡人或者赠卡人
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务方用户id
        /// </summary>
        [XmlElement("biz_user_id")]
        public string BizUserId { get; set; }

        /// <summary>
        /// 赠卡人在业务方的注册时间，用于安全校验
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 用户身份证号，用于安全校验
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 用户手机号，用于安全校验
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 用户实名姓名，用于安全校验
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 业务平台用户昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 支付宝user_id，代表亲情卡赠卡人或者赠卡人
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
