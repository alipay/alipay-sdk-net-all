using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfLiveSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfLiveSyncModel : AopObject
    {
        /// <summary>
        /// tab3生活号id
        /// </summary>
        [XmlElement("alipay_public_id")]
        public string AlipayPublicId { get; set; }

        /// <summary>
        /// 直播流地址
        /// </summary>
        [XmlElement("live_stream_url")]
        public string LiveStreamUrl { get; set; }

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
        /// 好大夫侧直播id
        /// </summary>
        [XmlElement("out_doc_live_id")]
        public string OutDocLiveId { get; set; }

        /// <summary>
        /// 直播名称
        /// </summary>
        [XmlElement("out_name")]
        public string OutName { get; set; }

        /// <summary>
        /// 好大夫侧预告id
        /// </summary>
        [XmlElement("out_prepare_id")]
        public string OutPrepareId { get; set; }
    }
}
