using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppBangdaoMsgUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppBangdaoMsgUploadModel : AopObject
    {
        /// <summary>
        /// 出账机构
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 销账机构
        /// </summary>
        [XmlElement("chargeoff_inst")]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 消息数据内容，JSON格式字符串
        /// </summary>
        [XmlElement("msg_notify_content")]
        public string MsgNotifyContent { get; set; }

        /// <summary>
        /// 消息通知类型
        /// </summary>
        [XmlElement("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 账单消息子业务类型
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
