using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfLiveCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfLiveCloseModel : AopObject
    {
        /// <summary>
        /// 支付宝侧直播id
        /// </summary>
        [XmlElement("alipay_live_id")]
        public string AlipayLiveId { get; set; }

        /// <summary>
        /// 直播预告类型 开播：live 预告：prepare
        /// </summary>
        [XmlElement("live_prepare_type")]
        public string LivePrepareType { get; set; }

        /// <summary>
        /// 好大夫侧医生id
        /// </summary>
        [XmlElement("out_doc_id")]
        public string OutDocId { get; set; }

        /// <summary>
        /// 好大夫侧直播id
        /// </summary>
        [XmlElement("out_live_id")]
        public string OutLiveId { get; set; }
    }
}
