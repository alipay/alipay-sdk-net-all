using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcocheckYzPolicyCheckDetail Data Structure.
    /// </summary>
    [Serializable]
    public class EcocheckYzPolicyCheckDetail : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 小程序是否上线，true代表是，false代表否
        /// </summary>
        [XmlElement("app_online_check")]
        public bool AppOnlineCheck { get; set; }

        /// <summary>
        /// 小程序月活用户数
        /// </summary>
        [XmlElement("mau")]
        public long Mau { get; set; }

        /// <summary>
        /// 是否接入消息能力，true代表是，false代表否
        /// </summary>
        [XmlElement("msg_check")]
        public bool MsgCheck { get; set; }

        /// <summary>
        /// 是否完成物料张贴，true代表是，false代表否
        /// </summary>
        [XmlElement("post_check")]
        public bool PostCheck { get; set; }

        /// <summary>
        /// 是否接入扫码能力，true代表是，false代表否
        /// </summary>
        [XmlElement("scan_check")]
        public bool ScanCheck { get; set; }

        /// <summary>
        /// 是否配置搜索关键词，true代表是，false代表否
        /// </summary>
        [XmlElement("searchkeyword_check")]
        public bool SearchkeywordCheck { get; set; }

        /// <summary>
        /// 是否完成服务提报，true代表是，false代表否
        /// </summary>
        [XmlElement("service_apply_check")]
        public bool ServiceApplyCheck { get; set; }

        /// <summary>
        /// 服务提报校验不通过的原因
        /// </summary>
        [XmlElement("service_apply_check_fail_reason")]
        public string ServiceApplyCheckFailReason { get; set; }

        /// <summary>
        /// 是否是三方小程序，true代表是，false代表否
        /// </summary>
        [XmlElement("thirdparty_app_check")]
        public bool ThirdpartyAppCheck { get; set; }

        /// <summary>
        /// 当月有效交易笔数
        /// </summary>
        [XmlElement("valid_trans_amount")]
        public long ValidTransAmount { get; set; }
    }
}
