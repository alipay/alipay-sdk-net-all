using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MsgSceneDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MsgSceneDTO : AopObject
    {
        /// <summary>
        /// 1.当biz_scene=INVITE_EMP_SIGN时，need_push、template_type和send_time为必填项 2.当biz_scene=EMP_SIGN_SUCCESS时，need_push、template_type和send_time非必填，默认need_push = false, template_type = COMMON，发送时间为即时发送（员工签约成功，立即推送）
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 是否需要push消息
        /// </summary>
        [XmlElement("need_push")]
        public bool NeedPush { get; set; }

        /// <summary>
        /// 发送时间，格式，HHmm，其中mm只能是整分钟（00，10，20，30，40，50）
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }
    }
}
