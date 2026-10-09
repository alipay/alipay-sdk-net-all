using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveInteractiveStateModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveInteractiveStateModifyModel : AopObject
    {
        /// <summary>
        /// 脱敏后的支付宝直播间ID
        /// </summary>
        [XmlElement("alipay_live_id")]
        public string AlipayLiveId { get; set; }

        /// <summary>
        /// 互动玩法的状态：0初始化，1开启，2关闭
        /// </summary>
        [XmlElement("interactive_status")]
        public long InteractiveStatus { get; set; }

        /// <summary>
        /// 互动类型，用于区分当前是哪个互动玩法
        /// </summary>
        [XmlElement("interactive_type")]
        public string InteractiveType { get; set; }

        /// <summary>
        /// 通用字段，用于做互动类型对应的跳转链接 例如类型为MEDICAL_ASK_DOCTOR时，那这个值代表的就是问医生的跳转链接
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 通用字段，用于做互动类型对应的数量展示（单位为个数） 例如类型为MEDICAL_POCKET时，那这个值代表的就是医疗小蓝车的商品数量
        /// </summary>
        [XmlElement("show_num")]
        public long ShowNum { get; set; }
    }
}
