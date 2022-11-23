using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarSystemTemplatemessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarSystemTemplatemessageSendModel : AopObject
    {
        /// <summary>
        /// 消息类容
        /// </summary>
        [XmlElement("msg_content")]
        public MsgContent MsgContent { get; set; }

        /// <summary>
        /// 消息动态信息,支持商户可透传自定义内容消息，当消息类型为VEHICLE_IOV_CONTROL，则可支持品牌名称
        /// </summary>
        [XmlArray("msg_dynamic_datas")]
        [XmlArrayItem("msg_dynamic_data")]
        public List<MsgDynamicData> MsgDynamicDatas { get; set; }

        /// <summary>
        /// 消息业务id,唯一标记一条消息信息
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 消息主体id 如消息类型为：VEHICLE_IOV_CONTROL，则该字段表示当前车辆id
        /// </summary>
        [XmlElement("msg_subject_id")]
        public string MsgSubjectId { get; set; }

        /// <summary>
        /// VEHICLE_IOV_CONTROL-车联车控
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 支付宝用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 跳转消息详情所需要的动态参数
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
