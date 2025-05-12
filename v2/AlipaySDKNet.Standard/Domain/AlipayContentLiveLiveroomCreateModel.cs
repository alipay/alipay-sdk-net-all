using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveLiveroomCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveLiveroomCreateModel : AopObject
    {
        /// <summary>
        /// 预告id，从创建预告接口获取
        /// </summary>
        [XmlElement("alipay_advance_id")]
        public string AlipayAdvanceId { get; set; }

        /// <summary>
        /// 用户生活号标识id
        /// </summary>
        [XmlElement("alipay_public_id")]
        public string AlipayPublicId { get; set; }

        /// <summary>
        /// 封面图片url地址，尺寸1:1
        /// </summary>
        [XmlElement("cover_url")]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 直播封面图片，尺寸3:4
        /// </summary>
        [XmlElement("cover_url_3_x_4")]
        public string CoverUrl3X4 { get; set; }

        /// <summary>
        /// 直播业务场景，调用前找直播平台协商。
        /// </summary>
        [XmlElement("live_biz_scene")]
        public string LiveBizScene { get; set; }

        /// <summary>
        /// 直播流地址
        /// </summary>
        [XmlElement("live_stream_url")]
        public string LiveStreamUrl { get; set; }

        /// <summary>
        /// 直播标题
        /// </summary>
        [XmlElement("live_title")]
        public string LiveTitle { get; set; }

        /// <summary>
        /// 外部直播id，和接口返回支付宝直播id对应
        /// </summary>
        [XmlElement("out_live_id")]
        public string OutLiveId { get; set; }
    }
}
