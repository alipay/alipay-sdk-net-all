using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserFacePaySkinInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserFacePaySkinInfo : AopObject
    {
        /// <summary>
        /// 支持该皮肤的客户端最低版本
        /// </summary>
        [XmlElement("client_version_limit")]
        public string ClientVersionLimit { get; set; }

        /// <summary>
        /// 北京时间皮肤过期日期(yyyy-MM-dd)，当日的23点59分59秒，若未领取/未授权 字段为空
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 皮肤名称001
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户去查看,去设置的跳转地址
        /// </summary>
        [XmlElement("setting_link")]
        public string SettingLink { get; set; }

        /// <summary>
        /// 皮肤ID
        /// </summary>
        [XmlElement("skin_id")]
        public string SkinId { get; set; }

        /// <summary>
        /// 0-未授权时状态 1-未领取 2-已领取&未设置 3-已领取&已设置
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        [XmlElement("thumbnail")]
        public string Thumbnail { get; set; }
    }
}
