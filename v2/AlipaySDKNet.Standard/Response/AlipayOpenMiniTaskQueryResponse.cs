using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniTaskQueryResponse.
    /// </summary>
    public class AlipayOpenMiniTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 关联的文创id
        /// </summary>
        [XmlElement("creative_id")]
        public string CreativeId { get; set; }

        /// <summary>
        /// 关联的购买订单号
        /// </summary>
        [XmlElement("creative_order_no")]
        public string CreativeOrderNo { get; set; }

        /// <summary>
        /// 生成失败时的原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 用户生图时的感想文案
        /// </summary>
        [XmlElement("feeling_text")]
        public string FeelingText { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("photos")]
        [XmlArrayItem("user_photo_info")]
        public List<UserPhotoInfo> Photos { get; set; }

        /// <summary>
        /// 生成的手帐结果图片
        /// </summary>
        [XmlElement("result_image_file_url")]
        public string ResultImageFileUrl { get; set; }

        /// <summary>
        /// 生成时的场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 状态成功还是失败SUCCESS/FAILED/PROCESSING
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 查询任务的id,事件通知时传递的id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 模板类型journal / poster
        /// </summary>
        [XmlElement("template_category")]
        public string TemplateCategory { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
