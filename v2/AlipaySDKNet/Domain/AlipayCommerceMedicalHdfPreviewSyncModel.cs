using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfPreviewSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfPreviewSyncModel : AopObject
    {
        /// <summary>
        /// tab3生活号id
        /// </summary>
        [XmlElement("alipay_public_id")]
        public string AlipayPublicId { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("out_action")]
        public string OutAction { get; set; }

        /// <summary>
        /// 直播预告封面链接
        /// </summary>
        [XmlElement("out_cover_img")]
        public string OutCoverImg { get; set; }

        /// <summary>
        /// 好大夫小程序医生主页跳转链接
        /// </summary>
        [XmlElement("out_doc_app_url")]
        public string OutDocAppUrl { get; set; }

        /// <summary>
        /// 好大夫侧医生id
        /// </summary>
        [XmlElement("out_doc_id")]
        public string OutDocId { get; set; }

        /// <summary>
        /// 预约开播时间 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("out_live_time")]
        public string OutLiveTime { get; set; }

        /// <summary>
        /// 外部的预告id，和支付宝直播域的预告id有关联
        /// </summary>
        [XmlElement("out_prepare_id")]
        public string OutPrepareId { get; set; }

        /// <summary>
        /// 对直播主题的简短描述
        /// </summary>
        [XmlElement("out_title")]
        public string OutTitle { get; set; }
    }
}
