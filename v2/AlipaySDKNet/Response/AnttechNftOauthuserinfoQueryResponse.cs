using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftOauthuserinfoQueryResponse.
    /// </summary>
    public class AnttechNftOauthuserinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 头像链接
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 中文名称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 鲸探用户ID标识，OpenApi场景使用的加密格式
        /// </summary>
        [XmlElement("ou_id")]
        public string OuId { get; set; }

        /// <summary>
        /// 4-7位脱敏后的手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 租户下用户id
        /// </summary>
        [XmlElement("tu_id")]
        public string TuId { get; set; }
    }
}
