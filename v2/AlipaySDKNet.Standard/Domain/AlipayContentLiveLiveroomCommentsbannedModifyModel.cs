using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveLiveroomCommentsbannedModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveLiveroomCommentsbannedModifyModel : AopObject
    {
        /// <summary>
        /// 加密后的直播ID，在直播间操作禁言或者解除禁言的时候传此参数，非直播间操作禁言或者解除禁言可以不传此参数
        /// </summary>
        [XmlElement("alipay_live_id")]
        public string AlipayLiveId { get; set; }

        /// <summary>
        /// 主播生活号ID
        /// </summary>
        [XmlElement("alipay_public_id")]
        public string AlipayPublicId { get; set; }

        /// <summary>
        /// 加密后的被操作禁言或者解除禁言的对象的生活号ID，这个数据信息支付宝用户在直播间评论并同步到外部直播间时会一起同步过去，可以从评论中获取该信息
        /// </summary>
        [XmlElement("operate_object_public_id")]
        public string OperateObjectPublicId { get; set; }

        /// <summary>
        /// 操作类型，1表示禁言，2表示解除禁言
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }
    }
}
