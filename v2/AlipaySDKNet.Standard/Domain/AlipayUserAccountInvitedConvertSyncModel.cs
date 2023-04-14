using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAccountInvitedConvertSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountInvitedConvertSyncModel : AopObject
    {
        /// <summary>
        /// 转化标签
        /// </summary>
        [XmlElement("convert_tag")]
        public string ConvertTag { get; set; }

        /// <summary>
        /// OpenId网关转换字段
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户转换同步场景
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝userid加密后token
        /// </summary>
        [XmlElement("user_token")]
        public string UserToken { get; set; }
    }
}
