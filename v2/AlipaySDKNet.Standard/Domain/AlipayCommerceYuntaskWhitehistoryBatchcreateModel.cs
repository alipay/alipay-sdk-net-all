using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskWhitehistoryBatchcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskWhitehistoryBatchcreateModel : AopObject
    {
        /// <summary>
        /// 操作人openid
        /// </summary>
        [XmlElement("operate_open_id")]
        public string OperateOpenId { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [XmlElement("operate_user_id")]
        public string OperateUserId { get; set; }

        /// <summary>
        /// 超导任务模版id，在超导SaaS后台针对任务点击操作时，将对应的任务id传过来
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }

        /// <summary>
        /// 白名单列表
        /// </summary>
        [XmlArray("white_list")]
        [XmlArrayItem("yun_task_white_user_d_t_o")]
        public List<YunTaskWhiteUserDTO> WhiteList { get; set; }
    }
}
