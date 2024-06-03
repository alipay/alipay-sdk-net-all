using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanCrowdexportQueryResponse.
    /// </summary>
    public class AlipayMerchantQipanCrowdexportQueryResponse : AopResponse
    {
        /// <summary>
        /// 人群唯一键
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 棋盘人群导出详情数据
        /// </summary>
        [XmlElement("crowd_export_data")]
        public CrowdExportData CrowdExportData { get; set; }

        /// <summary>
        /// 外部创建导出任务时传入的业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 棋盘返回的导出任务流水号
        /// </summary>
        [XmlElement("task_no")]
        public string TaskNo { get; set; }

        /// <summary>
        /// 导出任务状态
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }
    }
}
