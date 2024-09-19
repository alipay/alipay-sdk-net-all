using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcMsgTaskSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcMsgTaskSubmitModel : AopObject
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 消息场景列表
        /// </summary>
        [XmlArray("msg_scene_list")]
        [XmlArrayItem("msg_scene_d_t_o")]
        public List<MsgSceneDTO> MsgSceneList { get; set; }

        /// <summary>
        /// 企业生成的请求唯一流水号/业务幂等号； 字段作用： 1. 作为提交消息任务的幂等标识，使用相同的out_biz_no 会返回相同的任务id列表 2. 若调用失败或超时，可以使用相同的 out_biz_no 进行幂等重试
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
