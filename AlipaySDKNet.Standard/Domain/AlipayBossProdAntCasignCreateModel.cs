using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntCasignCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntCasignCreateModel : AopObject
    {
        /// <summary>
        /// 签署任务信息
        /// </summary>
        [XmlArray("ant_sign_task_request_list")]
        [XmlArrayItem("ant_sign_task_request")]
        public List<AntSignTaskRequest> AntSignTaskRequestList { get; set; }

        /// <summary>
        /// 应用来源
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        [XmlElement("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// 业务编号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型 CONTRACT,FILE,OTHER
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务线
        /// </summary>
        [XmlElement("business_line_code")]
        public string BusinessLineCode { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 签署过期日期间隔，从发起签署开始算起(传递毫秒数，如3天过期：3*24*60*60*1000L)
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 业务场景code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 签署任务类型 SINGLE_SEAL_CA,MICKLE_SEAL_CA,DIGITAL_SEAL
        /// </summary>
        [XmlElement("sign_task_type")]
        public string SignTaskType { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("sign_version")]
        public string SignVersion { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
