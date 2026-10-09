using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlescenterDocusignresultQueryResponse.
    /// </summary>
    public class AlipayBossProdAntlescenterDocusignresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务方申请单号
        /// </summary>
        [XmlElement("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 申请方系统标识，即来源系统
        /// </summary>
        [XmlElement("application_system")]
        public string ApplicationSystem { get; set; }

        /// <summary>
        /// 业务线编码
        /// </summary>
        [XmlElement("business_line_code")]
        public string BusinessLineCode { get; set; }

        /// <summary>
        /// ds证书合并签约文件
        /// </summary>
        [XmlElement("combined_file_vo")]
        public CreateESignTaskFileVO CombinedFileVo { get; set; }

        /// <summary>
        /// 合同id
        /// </summary>
        [XmlElement("contract_id")]
        public string ContractId { get; set; }

        /// <summary>
        /// 签约文件证书
        /// </summary>
        [XmlElement("create_e_sign_task_file_vo")]
        public CreateESignTaskFileVO CreateESignTaskFileVo { get; set; }

        /// <summary>
        /// 若失败，返回失败原因
        /// </summary>
        [XmlElement("fail_info")]
        public string FailInfo { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 签约文件列表
        /// </summary>
        [XmlArray("sign_file_list")]
        [XmlArrayItem("create_e_sign_task_file_v_o")]
        public List<CreateESignTaskFileVO> SignFileList { get; set; }

        /// <summary>
        /// 签署任务流水id，内部生成
        /// </summary>
        [XmlElement("sign_task_id")]
        public string SignTaskId { get; set; }

        /// <summary>
        /// 签字人状态
        /// </summary>
        [XmlArray("signer_dto")]
        [XmlArrayItem("recipient_sign_status_result_vo")]
        public List<RecipientSignStatusResultVo> SignerDto { get; set; }

        /// <summary>
        /// 任务处理状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
