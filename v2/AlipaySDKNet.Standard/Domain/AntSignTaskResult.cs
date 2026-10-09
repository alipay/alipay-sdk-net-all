using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntSignTaskResult Data Structure.
    /// </summary>
    [Serializable]
    public class AntSignTaskResult : AopObject
    {
        /// <summary>
        /// 签署完成的文件列表
        /// </summary>
        [XmlArray("ant_sign_file_result_list")]
        [XmlArrayItem("ant_sign_file_result")]
        public List<AntSignFileResult> AntSignFileResultList { get; set; }

        /// <summary>
        /// 签署人状态列表
        /// </summary>
        [XmlArray("ant_sign_operator_result_list")]
        [XmlArrayItem("ant_sign_operator_result")]
        public List<AntSignOperatorResult> AntSignOperatorResultList { get; set; }

        /// <summary>
        /// 签署子任务id
        /// </summary>
        [XmlElement("sign_task_id")]
        public string SignTaskId { get; set; }

        /// <summary>
        /// 签署子任务的状态
        /// </summary>
        [XmlElement("sign_task_status")]
        public string SignTaskStatus { get; set; }

        /// <summary>
        /// 子任务流水号
        /// </summary>
        [XmlElement("sub_biz_no")]
        public string SubBizNo { get; set; }
    }
}
