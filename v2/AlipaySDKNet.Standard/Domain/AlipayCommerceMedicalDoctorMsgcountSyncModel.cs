using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDoctorMsgcountSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDoctorMsgcountSyncModel : AopObject
    {
        /// <summary>
        /// AQ用户ID（2089、2090）
        /// </summary>
        [XmlElement("aq_user_id")]
        public string AqUserId { get; set; }

        /// <summary>
        /// AQ用户ID（2089、2090）
        /// </summary>
        [XmlElement("aq_user_open_id")]
        public string AqUserOpenId { get; set; }

        /// <summary>
        /// 外部传入，随机生成
        /// </summary>
        [XmlElement("out_app_id")]
        public string OutAppId { get; set; }

        /// <summary>
        /// 外部传入，随机生成
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 剩余未读消息数
        /// </summary>
        [XmlElement("un_read_count")]
        public long UnReadCount { get; set; }
    }
}
